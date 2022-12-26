using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace carsss
{
    public partial class Auth : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        public Auth()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Width, 44);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userLogin = loginField.Text;
            string userPass = passField.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"SELECT id, password, login from pupupu.registered WHERE login = '{userLogin}' and password = '{userPass}'";

            MySqlCommand command = new MySqlCommand(querystring, dataBase.GetSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string connStr = "server=localhost;port=3306;username=root;password=Polina2003/;database = pupupu;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql = $"SELECT role from registered WHERE login = '{userLogin}'";
                MySqlCommand roleCheck = new MySqlCommand(sql, conn);
                string formRole = roleCheck.ExecuteScalar().ToString();
                switch (formRole)
                {
                    
                    case "director":
                        var dir = new DirectorForm();
                        dir.Show(); Hide();
                        break;
                    case "manager":
                        var men = new ManagerForm();
                        men.Show(); Hide();
                        break;
                    case "seller":
                        var sel = new ShopAssistantForm();
                        sel.Show(); Hide();
                        break;
                    case "admin":
                        var adm = new AdminForm();
                        adm.Show(); Hide();
                        break;
                    default:
                        MessageBox.Show("Роль не определена", "Пароль или логин введены неверно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else MessageBox.Show("Такого аккаунта не существует", "Пароль или логин введены неверно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataBase.CloseConnection();
        }

        private void MainPlane_Click(object sender, EventArgs e)
        {

        }
        //private void MainPlane_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if(e.Button = MouseButtons.Left)
        //    {
        //        this.Left
        //    }

        //}
    }
}
