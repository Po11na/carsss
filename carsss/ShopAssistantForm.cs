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
    enum RoWStateSale
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted,
    }

    public partial class ShopAssistantForm : Form
    {
        DataBaseConnection dataBaseSale = new DataBaseConnection();
        int selectedRowSale;
        public ShopAssistantForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()//метод для вывода данных в DataGridView из таблицы MySQL
        {
            dataGridViewSale.Columns.Add("idsale", "id");
            dataGridViewSale.Columns.Add("marksale", "Марка");
            dataGridViewSale.Columns.Add("colorsale", "Цвет");
            dataGridViewSale.Columns.Add("yearsale", "Год");
            dataGridViewSale.Columns.Add("condsale", "Б/У / Новый");
            dataGridViewSale.Columns.Add("pricesale", "Цена");
            dataGridViewSale.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwgSale, IDataRecord record)
        {
            dwgSale.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4), record.GetInt32(5), RoWState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dwgSale)//метод вывода данных в таблицу
        {
            dwgSale.Rows.Clear();

            string queryString = $"select * from shopassistanttable";

            MySqlCommand command = new MySqlCommand(queryString, dataBaseSale.GetSqlConnection());

            dataBaseSale.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dwgSale, reader);
            }
            reader.Close();
        }


        private void CloseButtonShopAssistantForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dataGridViewSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowSale = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSale.Rows[selectedRowSale];

                textBox_IDSale.Text = row.Cells[0].Value.ToString();
                textBox_MarkSale.Text = row.Cells[1].Value.ToString();
                textBox_ColorSale.Text = row.Cells[2].Value.ToString();
                textBox_YearSale.Text = row.Cells[3].Value.ToString();
                textBox_ConditionSale.Text = row.Cells[4].Value.ToString();
                textBox_PriceSale.Text = row.Cells[5].Value.ToString();
            }
        }

        

        private void refreshSale_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewSale);
            ClearFields();
        }

        private void button_New_Sale_Click(object sender, EventArgs e)
        {
            AddShopAssistantForm addassf = new AddShopAssistantForm();
            addassf.Show();
        }

        private void Search(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string searchString = $"select * from shopassistanttable where  concat (idsale, marksale, colorsale, yearsale, condsale, pricesale) like '%" + textBox_SearchSale.Text + "%'";

            MySqlCommand com = new MySqlCommand(searchString, dataBaseSale.GetSqlConnection());

            dataBaseSale.OpenConnection();

            MySqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dwg, read);
            }

            read.Close();
        }

        private void searchSale_Click(object sender, EventArgs e)
        {

        }

        private void textBox_SearchSale_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridViewSale);
        }

        private void UpdateRow()
        {
            dataBaseSale.OpenConnection();
            for (int i = 0; i < dataGridViewSale.Rows.Count; i++)
            {
                var rowState = (RoWStateSale)dataGridViewSale.Rows[i].Cells[6].Value;
                if (rowState == RoWStateSale.Existed)
                    continue;

                if (rowState == RoWStateSale.Deleted)
                {
                    var delId = Convert.ToInt32(dataGridViewSale.Rows[i].Cells[0].Value);
                    var deleteQuary = $"delete from shopassistanttable where idsale = '{delId}'";
                    var command = new MySqlCommand(deleteQuary, dataBaseSale.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RoWStateSale.Modified)
                {
                    var id = dataGridViewSale.Rows[i].Cells[0].Value.ToString();
                    var mark = dataGridViewSale.Rows[i].Cells[1].Value.ToString();
                    var color = dataGridViewSale.Rows[i].Cells[2].Value.ToString();
                    var year = dataGridViewSale.Rows[i].Cells[3].Value.ToString();
                    var cond = dataGridViewSale.Rows[i].Cells[4].Value.ToString();
                    var price = dataGridViewSale.Rows[i].Cells[5].Value.ToString();
                    var changeQuery = $"update shopassistanttable set marksale = '{mark}', colorsale = '{color}', yearsale = '{year}', condsale = '{cond}', pricesale = '{price}' where idsale = '{id}'";
                    var command = new MySqlCommand(changeQuery, dataBaseSale.GetSqlConnection());
                    command.ExecuteNonQuery();
                }

            }
            dataBaseSale.CloseConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridViewSale.CurrentCell.RowIndex;
            int id;
            var mark = textBox_MarkSale.Text;
            var color = textBox_ColorSale.Text;
            int year;
            var cond = textBox_ConditionSale.Text;
            int price;

            if (dataGridViewSale.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if ((int.TryParse(textBox_PriceSale.Text, out price)) && (int.TryParse(textBox_IDSale.Text, out id)) && (int.TryParse(textBox_YearSale.Text, out year)))
                {
                    dataGridViewSale.Rows[selectedRowIndex].SetValues(id, mark, color, year, cond, price);
                    dataGridViewSale.Rows[selectedRowIndex].Cells[6].Value = RoWState.Modified;
                }
                else
                {
                    MessageBox.Show("id, цена и год должны иметь цифровой формат!");
                }
            }
        }

        private void button_Change_Sale_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void DeleteRow()
        {
            var selectedRowIndex = dataGridViewSale.CurrentCell.RowIndex;
            dataGridViewSale.Rows[selectedRowIndex].Visible = false;
            if (dataGridViewSale.Rows[selectedRowIndex].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewSale.Rows[selectedRowIndex].Cells[6].Value = RoWState.Deleted;
                return;
            }
            dataGridViewSale.Rows[selectedRowIndex].Cells[6].Value = RoWState.Deleted;
        }

        private void button_Delete_Sale_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void button_Save_Sale_Click(object sender, EventArgs e)
        {
            UpdateRow();
        }

        public void ClearFields()
        {
            textBox_IDSale.Text = "";
            textBox_MarkSale.Text = "";
            textBox_ColorSale.Text = "";
            textBox_YearSale.Text = "";
            textBox_ConditionSale.Text = "";
            textBox_PriceSale.Text = "";
        }

        private void clearSale_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ShopAssistantForm_Load_1(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridViewSale);

        }

        private void dataGridViewSale_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowSale = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSale.Rows[selectedRowSale];

                textBox_IDSale.Text = row.Cells[0].Value.ToString();
                textBox_MarkSale.Text = row.Cells[1].Value.ToString();
                textBox_ColorSale.Text = row.Cells[2].Value.ToString();
                textBox_YearSale.Text = row.Cells[3].Value.ToString();
                textBox_ConditionSale.Text = row.Cells[4].Value.ToString();
                textBox_PriceSale.Text = row.Cells[5].Value.ToString();
            }
        }

        
    }
}
