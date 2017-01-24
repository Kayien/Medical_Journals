using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Journals_Client
{
    public partial class Frm_Login : MetroFramework.Forms.MetroForm
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Validating empty username field
        private void btnSignin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "The field Username is requerid");
                txtUsername.Focus();
                return;
            }
            errorProvider1.SetError(txtUsername, "");
            //Validating empty password field
            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "The field Password is requerid");
                txtPassword.Focus();
                return;
            }
            errorProvider1.SetError(txtPassword, "");
        }
    }
}
