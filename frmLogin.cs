using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Assignment_1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtName.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string stat;
            
            Login obj1 = new Login(txtName.Text, txtPassword.Text);
            this.Hide();
            stat = obj1.login(txtName.Text);
            if (stat != null)
            {
                this.Show();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Exclamation;
                MessageBox.Show(stat,"Error!",buttons,icon);
                txtName.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtName.Focus();
            }
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Move focus to the next textbox
                txtPassword.Focus();
                // Select all text in the textbox
                // Prevent the key event from being passed on
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Perform button click action
                btnLogin.PerformClick();
                // Prevent the key event from being passed on
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


    }
}
