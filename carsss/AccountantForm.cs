using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carsss
{
    public partial class AccountantForm : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();

        int selectedRow;

        public AccountantForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {

            dataGridView2.Columns.Add("id_acc", "ID");
            dataGridView2.Columns.Add("mark_acc", "Модель");
            dataGridView2.Columns.Add("color_acc", "Цвет");
            dataGridView2.Columns.Add("year_acc", "Год");
            dataGridView2.Columns.Add("cond_acc", "Состояние");
            dataGridView2.Columns.Add("price_acc", "Доход с НДФ");
            dataGridView2.Columns.Add("IsNew", String.Empty);

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),record.GetString(1),record.GetString(2),record.GetInt32(3),record.GetString(4),record.GetInt32(5),RoWState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string sql = $"select * from accountant_table";

            MySqlCommand command = new MySqlCommand(sql, dataBase.GetSqlConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                accId.Text = row.Cells[0].Value.ToString();
                accMark.Text = row.Cells[1].Value.ToString();
                accColor.Text = row.Cells[2].Value.ToString();
                accYear.Text = row.Cells[3].Value.ToString();
                accCond.Text = row.Cells[4].Value.ToString();
                accPrice.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button_New_Nakl_Click(object sender, EventArgs e)
        {
            AddAccountantForm form = new AddAccountantForm();
            form.Show();
        }

        private void AccountantForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView2);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView2);
        }



        private void DeleteRow()
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows[index].Visible = false;

            if(dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView2.Rows[index].Cells[6].Value = RoWState.Deleted;
                return;
            }
            dataGridView2.Rows[index].Cells[6].Value = RoWState.Deleted;
        }

        private void button_Delete_Nakl_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void UpdateRow()
        {
            dataBase.OpenConnection();

            for(int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var rowState = (RoWState)dataGridView2.Rows[i].Cells[6].Value;

                if(rowState == RoWState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                    var delQuery = $"delete from accountant_table where id_acc = {id}";
                    MySqlCommand command = new MySqlCommand(delQuery,dataBase.GetSqlConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RoWState.Modified)
                {
                    var id = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    var mark = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    var color = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    var year = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    var cond = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    var price = dataGridView2.Rows[i].Cells[5].Value.ToString();

                    string updateQuery = $"update accountant_table set mark_acc = '{mark}', color_acc = '{color}', year_acc = '{year}', cond_acc = '{cond}', price_acc = '{price}' where id_acc = '{id}'";

                    MySqlCommand command = new MySqlCommand(updateQuery, dataBase.GetSqlConnection());

                    command.ExecuteNonQuery();
                }
            }
            dataBase.CloseConnection();
        }

        private void button_Save_Nakl_Click(object sender, EventArgs e)
        {
            UpdateRow();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchSql = $"select * from accountant_table where concat (id_acc, mark_acc, color_acc, year_acc, cond_acc, price_acc) like '%" + searchBox.Text + "%'";

            MySqlCommand command = new MySqlCommand(searchSql, dataBase.GetSqlConnection());

            dataBase.OpenConnection();

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView2);
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;

            int id = int.Parse(accId.Text);
            string mark = accMark.Text;
            string color = accColor.Text;
            int year = int.Parse(accYear.Text);
            string cond = accCond.Text;
            int price = int.Parse(accPrice.Text);

            if(dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString()!= string.Empty)
            {
                dataGridView2.Rows[selectedRowIndex].SetValues(id, mark, color, year, cond, price);
                dataGridView2.Rows[selectedRowIndex].Cells[6].Value = RoWState.Modified;
            }
        }

        private void button_Change_Nakl_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
