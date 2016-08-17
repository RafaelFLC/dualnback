namespace dualnBack
{
    partial class GameFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStar = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lboxRandom = new System.Windows.Forms.ListBox();
            this.lblToStart = new System.Windows.Forms.Label();
            this.pBox4 = new System.Windows.Forms.PictureBox();
            this.pBox3 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cerraGame = new System.Windows.Forms.Button();
            this.timerToStart = new System.Windows.Forms.Timer(this.components);
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerMsg = new System.Windows.Forms.Timer(this.components);
            this.menuPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuPanel.Controls.Add(this.button5);
            this.menuPanel.Controls.Add(this.button4);
            this.menuPanel.Controls.Add(this.button3);
            this.menuPanel.Controls.Add(this.button2);
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Location = new System.Drawing.Point(2, 6);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(126, 348);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button5.Location = new System.Drawing.Point(10, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(239, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "To log out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.Location = new System.Drawing.Point(10, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(239, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "Config";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Location = new System.Drawing.Point(10, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Perfil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(10, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Scores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(73, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStar
            // 
            this.btnStar.Location = new System.Drawing.Point(134, 133);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(261, 82);
            this.btnStar.TabIndex = 1;
            this.btnStar.Text = "Comenzar";
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gamePanel.Controls.Add(this.lblPuntos);
            this.gamePanel.Controls.Add(this.lboxRandom);
            this.gamePanel.Controls.Add(this.lblToStart);
            this.gamePanel.Controls.Add(this.pBox4);
            this.gamePanel.Controls.Add(this.pBox3);
            this.gamePanel.Controls.Add(this.pBox2);
            this.gamePanel.Controls.Add(this.pBox1);
            this.gamePanel.Controls.Add(this.lblMsg);
            this.gamePanel.Controls.Add(this.cerraGame);
            this.gamePanel.Location = new System.Drawing.Point(232, 6);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(349, 348);
            this.gamePanel.TabIndex = 5;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            this.gamePanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gamePanel_PreviewKeyDown);
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(12, 12);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(24, 25);
            this.lblPuntos.TabIndex = 17;
            this.lblPuntos.Text = "3";
            this.lblPuntos.Visible = false;
            // 
            // lboxRandom
            // 
            this.lboxRandom.FormattingEnabled = true;
            this.lboxRandom.Location = new System.Drawing.Point(17, 60);
            this.lboxRandom.Name = "lboxRandom";
            this.lboxRandom.Size = new System.Drawing.Size(36, 199);
            this.lboxRandom.TabIndex = 16;
            this.lboxRandom.Visible = false;
            // 
            // lblToStart
            // 
            this.lblToStart.AutoSize = true;
            this.lblToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToStart.Location = new System.Drawing.Point(96, 12);
            this.lblToStart.Name = "lblToStart";
            this.lblToStart.Size = new System.Drawing.Size(24, 25);
            this.lblToStart.TabIndex = 15;
            this.lblToStart.Text = "3";
            this.lblToStart.Visible = false;
            // 
            // pBox4
            // 
            this.pBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pBox4.Location = new System.Drawing.Point(101, 166);
            this.pBox4.Name = "pBox4";
            this.pBox4.Size = new System.Drawing.Size(90, 83);
            this.pBox4.TabIndex = 9;
            this.pBox4.TabStop = false;
            this.pBox4.Visible = false;
            // 
            // pBox3
            // 
            this.pBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pBox3.Location = new System.Drawing.Point(197, 165);
            this.pBox3.Name = "pBox3";
            this.pBox3.Size = new System.Drawing.Size(90, 83);
            this.pBox3.TabIndex = 8;
            this.pBox3.TabStop = false;
            this.pBox3.Visible = false;
            // 
            // pBox2
            // 
            this.pBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pBox2.Location = new System.Drawing.Point(197, 77);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(90, 83);
            this.pBox2.TabIndex = 7;
            this.pBox2.TabStop = false;
            this.pBox2.Visible = false;
            // 
            // pBox1
            // 
            this.pBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pBox1.Location = new System.Drawing.Point(101, 77);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(90, 83);
            this.pBox1.TabIndex = 6;
            this.pBox1.TabStop = false;
            this.pBox1.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMsg.Location = new System.Drawing.Point(35, 316);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(124, 20);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = "Press A : match ";
            // 
            // cerraGame
            // 
            this.cerraGame.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cerraGame.Location = new System.Drawing.Point(300, 6);
            this.cerraGame.Name = "cerraGame";
            this.cerraGame.Size = new System.Drawing.Size(50, 23);
            this.cerraGame.TabIndex = 0;
            this.cerraGame.Text = "Cerrar";
            this.cerraGame.UseVisualStyleBackColor = true;
            this.cerraGame.Click += new System.EventHandler(this.cerraGame_Click);
            // 
            // timerToStart
            // 
            this.timerToStart.Interval = 1000;
            this.timerToStart.Tick += new System.EventHandler(this.timerToStart_Tick);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 2000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerMsg
            // 
            this.timerMsg.Interval = 800;
            this.timerMsg.Tick += new System.EventHandler(this.timerMsg_Tick);
            // 
            // GameFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.btnStar);
            this.Controls.Add(this.menuPanel);
            this.Name = "GameFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dual n\'Back";
            this.Load += new System.EventHandler(this.GameFrm_Load);
            this.menuPanel.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button cerraGame;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox pBox4;
        private System.Windows.Forms.PictureBox pBox3;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Timer timerToStart;
        private System.Windows.Forms.Label lblToStart;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerMsg;
        private System.Windows.Forms.ListBox lboxRandom;
        private System.Windows.Forms.Label lblPuntos;
    }
}