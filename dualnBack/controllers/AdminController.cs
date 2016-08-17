using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dualnBack.models;

namespace dualnBack.controllers
{
    class AdminController
    {
        private static AdminController admn;

        public static AdminController New
        {
            get
            {
                if(admn == null)
                    admn = new AdminController();
                return admn;
            }
        }

        public List<userModel> getUsers()
        {
            return db.context.getUSers();
        }

        public List<userModel> deleteUser(string user)
        {
            var id = db.context.getIdUser(user);
            return db.context.deleteUser(id);
        } 
    }
}
