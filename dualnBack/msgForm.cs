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
    public partial class msgForm : Form
    {
        private Form form;
        private static msgForm msg;
        private msgForm()
        {
            InitializeComponent();
        }

        public static msgForm newMsg
        {
            get
            {
                if(msg == null)
                    msg = new msgForm();
                return msg;
            }
        }

        public void setMessage(string message)
        {
            label1.Text += message;
        }

        public void setRedirect(Form f)
        {
            form = f;
        }

        public msgForm(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void msgForm_Load(object sender, EventArgs e)
        {

        }

        private void msgForm_Close(object sender, FormClosedEventArgs e)
        {
            label1.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            form?.ShowDialog();
            this.Close();
        }
    }
}
