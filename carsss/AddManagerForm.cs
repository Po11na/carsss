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
    public partial class AddManagerForm : Form
    {
        

        public AddManagerForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_idManagerAdd.Text);
            var mark = textBox_MarkaManagerAdd.Text;
            var color = textBox_ColorManagerAdd.Text;
            int year = int.Parse(textBox_YearManagerAdd.Text);
            var condition = textBox_ConditionManagerAdd.Text;
            int price = int.Parse(textBox_PriceManagerAdd.Text);
            DataBaseConnection dataBase = new DataBaseConnection();

            var addQuery = $"INSERT INTO pupupu.menegertable (id, mark, color, year, condition, price) VALUES ('{id}''{mark}', '{color}', '{year}', '{condition}','{price}')";

            var command = new MySqlCommand(addQuery, dataBase.GetSqlConnection());
            dataBase.OpenConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заявка на поставку успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }





            //else
            //{
            //    MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //dataBase.CloseConnection();

        }
    }
}
