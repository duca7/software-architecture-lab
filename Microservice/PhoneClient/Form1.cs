using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };
            bool result = new AccountBUS().CheckAccount(account);
            if (result)
            {
                new PhoneForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("SORRY BRO!");
            }
        }

        private void bntRegister_Click(object sender, EventArgs e)
        {
            Account newAccount = new Account()
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };
            bool result = new AccountBUS().AddNew(newAccount);
            if (result)
            {
                MessageBox.Show("Ok Ok");
            }
            else
            {
                MessageBox.Show("SORRY BRO!");
            }
        }

        
    }
}
