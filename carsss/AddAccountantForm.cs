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
    public partial class AddAccountantForm : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        public AddAccountantForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void saveAccountant_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
            string mark = marka.Text;
            string color = colorField.Text;
            int year;
            string cond = condition.Text;
            int price;
            if ((int.TryParse(priceField.Text, out price)) && (int.TryParse(yearField.Text, out year)))
            {
                var addQuery = $"INSERT INTO acctable ( mark, color, year, cond, price) VALUES ('{mark}', '{color}', '{year}', '{cond}','{price}')";

                var command = new MySqlCommand(addQuery, dataBase.GetSqlConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Заявка на поставку успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена и год должны иметь цифровой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.CloseConnection();
            marka.Text = colorField.Text = condition.Text = yearField.Text = priceField.Text = "";
        }
    }
}
