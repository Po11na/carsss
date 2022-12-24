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

            string querystring = $"SELECT id, password, login from automir.registered WHERE login = '{userLogin}' and password = '{userPass}'";

            MySqlCommand command = new MySqlCommand(querystring, dataBase.GetSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                var menu = new MenegerForm();
                menu.Show(); Hide();
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
