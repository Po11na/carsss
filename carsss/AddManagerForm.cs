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
        DataBaseConnection dataBase = new DataBaseConnection();
        public AddManagerForm()
        {
            InitializeComponent();
        }

        private void AddManagerForm_Load(object sender, EventArgs e)
        {

        }
        private void saveButtonAddManager_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
            string mark = marka.Text;
            string color = textBox_colorAddManager.Text;
            int year;
            string cond = condition.Text;
            int price;
            if((int.TryParse(textBox_priceAddManager.Text, out price)) &&(int.TryParse(textBox_yearAddManager.Text, out year)))
            {
                var addQuery = $"INSERT INTO menegertable ( mark, color, year, cond, price) VALUES ('{mark}', '{color}', '{year}', '{cond}','{price}')";

                var command = new MySqlCommand(addQuery, dataBase.GetSqlConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Заявка на поставку успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена и год должны иметь цифровой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.CloseConnection();
        }
    }
}
