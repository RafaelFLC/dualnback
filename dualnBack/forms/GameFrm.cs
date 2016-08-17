using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dualnBack.controllers;

namespace dualnBack
{
    public partial class GameFrm : Form
    {
        private static GameFrm game;
        private bool menuP;
        private bool gameP;
        private bool inGame;
        private int ToStar;
        private Color bColor;
        private Dictionary<Func<int, bool>, Action> myS;
        private List<int> nRandoms;
        private int R;
        private int puntos;
        private int tCount;
        private static string userName;
        private int rCount;

        private GameFrm()
        {
            InitializeComponent();
            menuP = true;
            gameP = false;
            inGame = false;
            menuPanel.Size = new Size(55, 348);
            changePositionGame();
            changePositionMenu();
            initPictureB();
            ToStar = 3;
            R = 0;
            puntos = 15;
            nRandoms = new List<int>();
            bColor = Color.DeepSkyBlue;
            myS = new Dictionary<Func<int, bool>, Action>
            {
                 { x => x == 0 , () => pBox1.BackColor = bColor},
                 { x => x == 1 , () => pBox2.BackColor = bColor},
                 { x => x == 2 , () => pBox3.BackColor = bColor},
                 { x => x == 3 , () => pBox4.BackColor = bColor}
            };
        }

        public static void setUserName(string username)
        {
            userName = username;
        }

        public static GameFrm New
        {
            get
            {
                if (game == null)
                    game = new GameFrm();

                return game;
            }
        }

        private void GameFrm_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            changePositionMenu();

        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            changePositionGame();
            tCount = 0;
            clean();
        }

        private void clean()
        {
            initPictureB();
            for (int i  = 0; i < lboxRandom.Items.Count; i++)
            {
                lboxRandom.Items.Remove(i);
            }
        }

        private void cerraGame_Click(object sender, EventArgs e)
        {
            changePositionGame();
            ToStar = 3;
            timerToStart.Stop();

        }

        private void changePositionMenu()
        {
            if (!menuP)
            {
                menuPanel.Size = new Size(348, 348);
                btnStar.Visible = false;
                menuP = true;
                gameP = false;
                changePositionGame();
                foreach (var obj in menuPanel.Controls)
                {
                    if (obj is Button)
                    {
                        Button b = (Button)obj;
                        if (b.Text != "menu")
                            b.Visible = true;
                    }
                }
            }
            else
            {
                menuPanel.Size = new Size(55, 348);
                btnStar.Visible = true;
                menuP = false;

                foreach (var obj in menuPanel.Controls)
                {
                    if (obj is Button)
                    {
                        Button b = (Button) obj;
                        if (b.Text != "menu")
                            b.Visible = false;
                    }
                }
            }
        }

        private void changePositionGame()
        {
            if (!gameP)
            {
                gamePanel.Size = new Size(50, 348);
                gamePanel.Location = new Point(572, 6);
                gameP = true;
            }
            else
            {
                gamePanel.Size = new Size(485, 348);
                gamePanel.Location = new Point(96, 6);
                gamePanel.Focus();
                timerToStart.Enabled = true;
                menuP = true;
                changePositionMenu();
                timerToStart.Start();
                gameP = false;
            }
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void gamePanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!inGame)
                return;  

            if (validate())
            {
                lblMsg.ForeColor = Color.Green;
                puntos++;
            }
            else
            {
                lblMsg.ForeColor = Color.Red;
                puntos--;
            }

            lblPuntos.Text = puntos.ToString();
            timerMsg.Start();

        }

        private bool validate()
        {
            if (nRandoms.Count <= 2)
                return false;

            var x = nRandoms[nRandoms.Count - 3];
            if (nRandoms.Count <= 1) return false;
            return R == x;
        }

        private void timerToStart_Tick(object sender, EventArgs e)
        {
            
            lblToStart.Text = ToStar.ToString();
            lblToStart.Visible = true;
            if (ToStar == 0)
            {
                timerToStart.Stop();
                ToStar = 3;
                lblToStart.Visible = false;
                foreach (var ctrl in this.gamePanel.Controls.OfType<PictureBox>())
                {
                    ctrl.Visible = true;
                    ctrl.BackColor = Color.AliceBlue;
                }

                startGame();
            }

            ToStar--;
        }

        private void startGame()
        {
            inGame = true;
            lblToStart.Visible = true;
            timerGame.Start();
        }

        
         
        private void timerGame_Tick(object sender, EventArgs e)
        {
            if (tCount <= 15)
            {

                var rand = new Random();
                R = rand.Next(0, 3);
                while (R == rCount)
                {
                    R = rand.Next(0, 3);
                }
                rCount = R;
                initPictureB();
                int toAdd = R;
                nRandoms.Add(toAdd);
                lboxRandom.Items.Add(toAdd);
                if (validate())
                    puntos--;

                lblPuntos.Text = puntos.ToString();
                lblToStart.Text = nRandoms.Last().ToString();
                myS.First(x => x.Key(R)).Value();
            }
            else
            {
                timerGame.Stop();
                var calif = getAVG();
                saveGame(calif);
                MessageBox.Show("juego Terminado puntos: " + puntos + ", calif: " + calif);
            }
            tCount++;

        }

        private void saveGame(int s)
        {
            gameController.New.setNewScore(userName, s);
        }

        private int getAVG()
        {
            if (puntos >= 14 && puntos <= 15)
                return 10;
            if (puntos >= 13 && puntos < 14)
                return 9;
            if (puntos >= 10 && puntos < 13)
                return 8;
            if (puntos >= 7 && puntos < 10)
                return 7;
            if (puntos >= 5 && puntos < 7)
                return 6;
            if (puntos >= 3 && puntos < 5)
                return 5;
            
            return 0;

        }

        private void initPictureB()
        {
            foreach (var p in gamePanel.Controls.OfType<PictureBox>())
            {
                p.BackColor = Color.AliceBlue;
            }
        }

        private Random getRandom()
        {
            Random r = new Random();
            return r;
        }

        private void timerMsg_Tick(object sender, EventArgs e)
        {
            lblMsg.ForeColor = Color.Black;
            timerMsg.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var scoresStr = "";
            var scores = gameController.New.getScoresH(userName);
            foreach (var s in scores)
            {
                scoresStr += s.user + " > " + s.score + "\n";
            }
            MessageBox.Show(scoresStr);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginController lg = new LoginController();
            lg.logOut();

        }
    }
}
