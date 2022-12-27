using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace carsss
{
    enum RoWState
    {
        Existed,
        New, 
        Modified,
        ModifiedNew,
        Deleted,
    }
    
    public partial class ManagerForm : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();

        int selectedRow;

        public ManagerForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()//метод для вывода данных в DataGridView из таблицы MySQL
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("mark", "Марка");
            dataGridView1.Columns.Add("color", "Цвет");
            dataGridView1.Columns.Add("year", "Год");
            dataGridView1.Columns.Add("cond", "Б/У / Новый");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4), record.GetInt32(5), RoWState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dwg)//метод вывода данных в таблицу
        {
            dwg.Rows.Clear();

            string queryString = $"select * from menegertable";

            MySqlCommand command = new MySqlCommand(queryString, dataBase.GetSqlConnection());

            dataBase.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_Mark.Text = row.Cells[1].Value.ToString();
                textBox_Color.Text = row.Cells[2].Value.ToString();
                textBox_Year.Text = row.Cells[3].Value.ToString();
                textBox_Condition.Text = row.Cells[4].Value.ToString();
                textBox_Price.Text = row.Cells[5].Value.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void button_New_Postavka_Click(object sender, EventArgs e)
        {
            AddManagerForm addmanf = new AddManagerForm();
            addmanf.Show();
        }

        private void Search(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string searchString = $"select * from menegertable where  concat (id, mark, color, year, cond, price) like '%" + textBox_Search.Text + "%'";

            MySqlCommand com = new MySqlCommand(searchString, dataBase.GetSqlConnection());

            dataBase.OpenConnection();

            MySqlDataReader read = com.ExecuteReader();

            while(read.Read())
            {
                ReadSingleRow(dwg, read);
            }

            read.Close();
        }


        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void UpdateRow()
        {
            dataBase.OpenConnection();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowState = (RoWState)dataGridView1.Rows[i].Cells[6].Value;
                if (rowState == RoWState.Existed)
                    continue;

                if (rowState == RoWState.Deleted)
                {
                    var delId = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    var deleteQuary = $"delete from menegertable where id = '{delId}'";
                    var command = new MySqlCommand(deleteQuary, dataBase.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
                if(rowState == RoWState.Modified)
                {
                    var id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    var mark = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    var color = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    var year = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    var cond = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    var price = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    var changeQuery = $"update menegertable set mark = '{mark}', color = '{color}', year = '{year}', cond = '{cond}', price = '{price}' where id = '{id}'";
                    var command = new MySqlCommand(changeQuery, dataBase.GetSqlConnection());
                    command.ExecuteNonQuery();
                }

            }
            dataBase.CloseConnection();
        }


        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            int id;
            var mark = textBox_Mark.Text;
            var color = textBox_Color.Text;
            int year;
            var cond = textBox_Condition.Text;
            int price;

            if(dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if ((int.TryParse(textBox_Price.Text, out price)) && (int.TryParse(textBox_ID.Text, out id)) && (int.TryParse(textBox_Year.Text, out year)))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, mark, color, year, cond, price);
                    dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RoWState.Modified;
                }
                else
                {
                    MessageBox.Show("id, цена и год должны иметь цифровой формат!");
                }
            }
        }
 

        private void button_Change_Postavka_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void DeleteRow()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[selectedRowIndex].Visible = false;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RoWState.Deleted;
                return;
            }
            dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RoWState.Deleted;
        }

        private void button_Delete_Postavka_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void button_Save_Postavka_Click(object sender, EventArgs e)
        {
            UpdateRow();
        }

        public void ClearFields()
        {
            textBox_ID.Text = "";
            textBox_Mark.Text = "";
            textBox_Color.Text = "";
            textBox_Year.Text = "";
            textBox_Condition.Text = "";
            textBox_Price.Text = "";
        }

        private void clearSale_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
