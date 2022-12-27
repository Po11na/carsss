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
        Resolver res = new Resolver();
        DataBaseConnection dataBase = new DataBaseConnection();
        public AddAccountantForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TaxesCount()
        {
            int price = int.Parse(priceField.Text);
            int priceWithNDF = (int)(price - (price* 0.13));
            priceField.Text = Convert.ToString(priceWithNDF);
        }

        private void saveAccountant_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
            string mark = marka.Text;
            string color = colorField.Text;
            int year = int.Parse(yearField.Text);
            string cond = condition.Text;
            int price = res.TaxesCount(int.Parse(priceField.Text));
            var addQuery = $"INSERT INTO acctable ( mark, color, year, cond, price) VALUES ('{mark}', '{color}', '{year}', '{cond}','{price}')";
            var command = new MySqlCommand(addQuery, dataBase.GetSqlConnection());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успех");
            }

            dataBase.CloseConnection();
            marka.Text = colorField.Text = condition.Text = yearField.Text = priceField.Text = "";
        }
    }
}
