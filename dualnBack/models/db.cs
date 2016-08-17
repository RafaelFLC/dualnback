using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dualnBack.models;
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

        public int getIdUser(string username)
        {
            var sql = "select id from users where user like '%" + username + "%'";
            conn.Open();
            var cmd = new MySqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            reader.Read();
            var id = reader.GetInt32(0);
            conn.Close();
            return id;
        }

        public List<userModel> getUSers()
        {
            var list = new List<userModel>();

            conn.Open();
            var sql = "select u.id, user, count(l.id) as logs, AVG(s.score) as score FROM users u right join logs l on l.idUser = u.id right join scores s on s.idUser = u.id group by u.id;";
            var cmd = new MySqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new userModel()
                {
                    id = reader.GetInt32(0),
                    user = reader[1].ToString(),
                    score = reader.GetInt32(2),
                    logs = reader.GetInt32(3)
                });
            }

            conn.Close();

            return list;
        }


        public List<userModel> deleteUser(int id)
        {
            var list = new List<userModel>();
            conn.Open();
            var sql = "delete from users where id = '" + id + "';select u.id, user, count(l.id) as logs, AVG(s.score) as score FROM users u right join logs l on l.idUser = u.id right join scores s on s.idUser = u.id group by u.id;";
            var cmd = new MySqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new userModel()
                {
                    id = reader.GetInt32(0),
                    user = reader.GetString(1),
                    score = reader.GetInt32(3), 
                    logs = reader.GetInt32(3)
                });
            }

            return list;
        } 

        public List<ScoreModel> getScores(int idUser)
        {
            conn.Open();
            var sql = "select s.score, u.user from scores s inner join users u on u.id = s.idUser where u.id = '" + idUser + "'";
            var cmd = new MySqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            List<ScoreModel> l = new List<ScoreModel>();
            while (reader.Read())
            {
                ScoreModel tmp = new ScoreModel()
                {
                    score = reader.GetInt32(0),
                    user = reader.GetString(1)
                };

                l.Add(tmp);
            }

            conn.Close();
            return l;
            
        }

        public int checkUserAndPass(string user, string pass)
        {
            conn.Open();
            string sql = "select idRole, id from users where (user ='" + user + "' and password = '" + pass + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            var r = 0;
            var idUser = 0;
            while (reader.Read())
            {
                r = (reader.FieldCount >= 1) ? reader.GetInt32(0) : 0;
                if (r != 0)
                    idUser = reader.GetInt32(1);
            }
            conn.Close();

            if (idUser != 0)
                newLog(idUser);

            return r;
        }

        public bool newScore(int idUser, int score)
        {
            string sql = "insert into scores (idUser, datetime, score) values ('"+ idUser +"', '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "', " + score + ")";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            var r = cmd.ExecuteNonQuery();
            conn.Close();
            return r == 1;
        }

        public bool newLog(int idUser)
        {
            string sql = "insert into logs (idUser, datetime) values ('" + idUser + "', '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "')";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
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
