using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeslenmeTakipSistemi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();   
            this.Hide();
            register.ShowDialog();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreGoster.Checked)
            {
                tbSifre.PasswordChar = '\0';
            }
            else
            {
                tbSifre.PasswordChar = '*';
            }
        }

        private void btn_ext_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
