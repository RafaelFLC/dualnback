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
    public partial class GameFrm : Form
    {
        private static GameFrm game;
        private GameFrm()
        {
            InitializeComponent();
        }

        public static GameFrm New
        {
            get
            {
                if(game == null)
                    game = new GameFrm();

                return game;
            }
        }

        private void GameFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
