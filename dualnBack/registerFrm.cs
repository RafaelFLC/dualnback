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
    public partial class registerFrm : Form
    {
        private LoginController login;
        private msgForm _msg;
        private static registerFrm r;

        private registerFrm()
        {
            InitializeComponent();
            login = new LoginController();
            _msg = msgForm.newMsg;
        }

        public static registerFrm New
        {
            get
            {
                if(r == null)
                    r = new registerFrm();
                return r;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            if (username != "")
            {
                this.Hide();
                login.registrar(username, password);
            }
            else
            {
                _msg.setMessage("Ingresar usuario");
                _msg.ShowDialog();
            }
        }
    }
}
