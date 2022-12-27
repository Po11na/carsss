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
            dataGridView2.Columns.Add("id", "ID");
            dataGridView2.Columns.Add("mark", "Модель");
            dataGridView2.Columns.Add("color", "Цвет");
            dataGridView2.Columns.Add("year", "Год");
            dataGridView2.Columns.Add("cond", "Состояние");
            dataGridView2.Columns.Add("price", "Стоимость");
            dataGridView2.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),record.GetString(1),record.GetString(2),record.GetInt32(3),record.GetString(4),record.GetInt32(5),RoWState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string sql = $"select * from acctable";

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
    }
}
