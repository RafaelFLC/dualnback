using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dualnBack
{
    public partial class LoginFrm : Form
    {
        private LoginController _loginC;
        private static LoginFrm login;

        private LoginFrm()
        {
            InitializeComponent();
            _loginC = new LoginController();
        }

        public static LoginFrm newLogin
        {
            get
            {
                if(login == null)
                    login = new LoginFrm();

                return login;
            }
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerFrm r = registerFrm.New;
            this.Hide();
            r.ShowDialog();
            this.Show();

            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var user = txtUser.Text;
            var pass = txtPass.Text;
            if (user == "")
            {
                msgForm.newMsg.setMessage("Ingresar usuario");

                if (pass == "")
                    msgForm.newMsg.setMessage(", ingresar password");

                msgForm.newMsg.ShowDialog();
            }
            else
            {
                this.Hide();
                _loginC.ingresar(user, pass);
               
            }
        }
    }
}
