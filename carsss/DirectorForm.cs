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
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void manButton_Click(object sender, EventArgs e)
        {
            var managerForm = new ManagerForm();
            managerForm.Show(); this.Hide();
        }

        private void accButton_Click(object sender, EventArgs e)
        {
            var accountantForm = new AccountantForm();
            accountantForm.Show(); this.Hide();
        }

        private void selButton_Click(object sender, EventArgs e)
        {
            var sellerForm = new ShopAssistantForm();
            sellerForm.Show(); this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
