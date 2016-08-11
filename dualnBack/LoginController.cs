using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Common;


namespace dualnBack
{
    class LoginController
    {
        public void ingresar(string user, string pass)
        {
            var result = db.context.checkUserAndPass(user, pass);
            if (result == 2)
                GameFrm.New.ShowDialog();
            else if (result == 1)
                AdminFrm.New.ShowDialog();
            else
            {
                LoginFrm.newLogin.Show();
                msgForm.newMsg.setMessage("no encongrado");
                msgForm.newMsg.ShowDialog();
            }

        }

        public void registrar(string user, string pass)
        {
            msgForm m = msgForm.newMsg;
            var result = db.context.newUser(user, pass);
            if (result)
            {
                m.setMessage("guardado con éxito");
                m.setRedirect(GameFrm.New);
                
            }
            else
            {
                m.setMessage("hubo un error");
            }
            m.ShowDialog();

            return;
        }
    }
}
