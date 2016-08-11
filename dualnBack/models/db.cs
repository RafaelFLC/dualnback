using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dualnBack
{
    class db
    {
        private static db instance;
        private static string sConn;
        private static MySqlConnection conn;
        private db()
        {
            sConn = "server=localhost; user=root;database=dualnback; password=qwerty";
            conn = new MySqlConnection(sConn);
        }

        public static db context
        {
            get
            {
                if(instance == null)
                    instance = new db();

                return instance;
            }
        }

        

        public List<string> getScores(int idUser)
        {
            conn.Open();
            var sql = "select * from scores where idUser = " + idUser;
            var cmd = new MySqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            List<string> l = new List<string>();
            conn.Close();
            while (reader.Read())
            {
                l.Add(reader[1].ToString());
            }
            return l;
            
        }

        public int checkUserAndPass(string user, string pass)
        {
            conn.Open();
            string sql = "select idRole from users where (user ='" + user + "' and password = '" + pass + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            reader.Read();
            var r = (reader.FieldCount >= 1) ? reader.GetInt32(0) : 0;
            conn.Close();
            return r;
        }

        public bool newUser(string user, string pass)
        {
            conn.Open();
            string sql = "INSERT INTO users (user, password, idRole) VALUES('" + user + "', '" + pass + "', 2)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            var result = cmd.ExecuteNonQuery();
            conn.Close();
            return result == 1;
        }
    }
}
