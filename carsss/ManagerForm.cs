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
            dataGridView1.Columns.Add("condition", "Б/У / Новый");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex <=0)
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
        }

        private void button_New_Postavka_Click(object sender, EventArgs e)
        {
            AddManagerForm addmanf = new AddManagerForm();
            addmanf.Show();
        }
    }
}
