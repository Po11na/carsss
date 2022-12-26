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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string login = textBox_Login.Text;
            string role = textBox_Role.Text;
            string password = textBox_Password.Text;
            DataBaseConnection dataBaseConnection = new DataBaseConnection();

            string sql = $"insert into automir.registered(name,login,password,role) values('{name}', '{login}', '{password}','{role}')";

            MySqlCommand command = new MySqlCommand(sql, dataBaseConnection.GetSqlConnection());
            dataBaseConnection.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пользователь добавлен","Успех");
            }
        }
    }
}
