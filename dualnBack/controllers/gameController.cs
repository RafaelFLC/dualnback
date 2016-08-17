using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dualnBack.models;

namespace dualnBack.controllers
{
    class gameController
    {
        private static gameController ctrl;

        public static gameController New
        {
            get
            {
                if (ctrl == null)
                    ctrl = new gameController();
                return ctrl;
            }
        }

        public bool setNewScore(string user, int score)
        {
            var id = db.context.getIdUser(user);
            return db.context.newScore(id, score);
        }

        public List<ScoreModel> getScoresH(string User)
        {
            var id = db.context.getIdUser(User);
            return db.context.getScores(id);
        } 
    }
}
