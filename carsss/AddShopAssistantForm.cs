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
    public partial class AddShopAssistantForm : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        public AddShopAssistantForm()
        {
            InitializeComponent();
        }

        private void AddShopAssistantForm_Load(object sender, EventArgs e)
        {

        }

        private void saveButtonAddShopAssistant_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
            string mark = textBox_markAddShopAssistant.Text;
            string color = textBox_colorAddShopAssistant.Text;
            int year;
            string cond = textBox_conditionAddShopAssistant.Text;
            int price;
            if ((int.TryParse(textBox_priceAddShopAssistant.Text, out price)) && (int.TryParse(textBox_yearAddShopAssistant.Text, out year)))
            {
                var addQuery = $"INSERT INTO shopassistanttable ( marksale, colorsale, yearsale, condsale, pricesale) VALUES ('{mark}', '{color}', '{year}', '{cond}','{price}')";

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

        private void CloseButtonShopAssistantForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
