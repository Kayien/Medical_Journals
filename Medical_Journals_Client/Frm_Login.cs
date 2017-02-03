using CAD_Medical_Journals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

            //Encriptar el password
            Crypto Encriptado = new Crypto();
            Encriptado.Encriptar(txtPassword.Text);
            string passEncrypted = Encriptado.Encriptar(txtPassword.Text);
            
            // validar en BD
                 if (!CADUser.ValidaUser(txtUsername.Text, passEncrypted ))
                    {
                //notificación de accesso
                     notifyIcon1.BalloonTipTitle = "Access Deneged!";
                     notifyIcon1.BalloonTipText ="Username or Password incorrect";
                     notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                     notifyIcon1.Visible = true;
                     notifyIcon1.ShowBalloonTip(3000);
                     txtUsername.Text = "";
                     txtPassword.Text = "";
                     txtUsername.Focus();
                     return;
                    }
                     Frm_MainView Publications = new Frm_MainView();
                     Publications.UsuarioLog = CADUser.GetUser(txtUsername.Text);
                     Publications.Show();
                     this.Hide();
                 notifyIcon1.BalloonTipTitle = "Welcome! to Medical Journals";
                 notifyIcon1.BalloonTipText = "We are ready for you ";
                 notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                 notifyIcon1.Visible = true;
                 notifyIcon1.ShowBalloonTip(3000);
             
        }
    }
}
