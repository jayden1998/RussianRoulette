namespace RussianRouletteGame
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbTrump = new System.Windows.Forms.RadioButton();
            this.btnSpin = new System.Windows.Forms.Button();
            this.rbAway = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHiScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.txtHiScore = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pbTrump = new System.Windows.Forms.PictureBox();
            this.pbRevolver = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRevolver)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbTrump);
            this.panel1.Controls.Add(this.btnSpin);
            this.panel1.Controls.Add(this.rbAway);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Location = new System.Drawing.Point(354, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 155);
            this.panel1.TabIndex = 0;
            // 
            // rbTrump
            // 
            this.rbTrump.AutoSize = true;
            this.rbTrump.Location = new System.Drawing.Point(18, 115);
            this.rbTrump.Name = "rbTrump";
            this.rbTrump.Size = new System.Drawing.Size(94, 17);
            this.rbTrump.TabIndex = 12;
            this.rbTrump.TabStop = true;
            this.rbTrump.Text = "Point at Trump";
            this.rbTrump.UseVisualStyleBackColor = true;
            this.rbTrump.CheckedChanged += new System.EventHandler(this.rbTrump_CheckedChanged);
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(13, 43);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(99, 30);
            this.btnSpin.TabIndex = 8;
            this.btnSpin.Text = "Spin chamber";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // rbAway
            // 
            this.rbAway.AutoSize = true;
            this.rbAway.Location = new System.Drawing.Point(18, 92);
            this.rbAway.Name = "rbAway";
            this.rbAway.Size = new System.Drawing.Size(78, 17);
            this.rbAway.TabIndex = 12;
            this.rbAway.TabStop = true;
            this.rbAway.Text = "Point Away";
            this.rbAway.UseVisualStyleBackColor = true;
            this.rbAway.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(13, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 31);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load Bullet";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnHiScores);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnRestart);
            this.panel2.Location = new System.Drawing.Point(354, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 109);
            this.panel2.TabIndex = 1;
            // 
            // btnHiScores
            // 
            this.btnHiScores.Location = new System.Drawing.Point(18, 69);
            this.btnHiScores.Name = "btnHiScores";
            this.btnHiScores.Size = new System.Drawing.Size(96, 27);
            this.btnHiScores.TabIndex = 11;
            this.btnHiScores.Text = "Hi-Scores";
            this.btnHiScores.UseVisualStyleBackColor = true;
            this.btnHiScores.Click += new System.EventHandler(this.btnHiScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(17, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 27);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(18, 3);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(96, 27);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Main Menu";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnFire
            // 
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(12, 280);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(471, 86);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // txtHiScore
            // 
            this.txtHiScore.Location = new System.Drawing.Point(240, 398);
            this.txtHiScore.Name = "txtHiScore";
            this.txtHiScore.ReadOnly = true;
            this.txtHiScore.Size = new System.Drawing.Size(108, 20);
            this.txtHiScore.TabIndex = 12;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(240, 372);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(108, 20);
            this.txtUser.TabIndex = 13;
            this.txtUser.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter your username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Your HiScore:";
            // 
            // pb6
            // 
            this.pb6.Image = global::RussianRouletteGame.Properties.Resources.PNGPIX_COM_Bullet_PNG_Transparent_Image_1;
            this.pb6.Location = new System.Drawing.Point(297, 165);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(51, 109);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 11;
            this.pb6.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Image = global::RussianRouletteGame.Properties.Resources.PNGPIX_COM_Bullet_PNG_Transparent_Image_1;
            this.pb5.Location = new System.Drawing.Point(240, 165);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(51, 109);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 10;
            this.pb5.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = global::RussianRouletteGame.Properties.Resources.PNGPIX_COM_Bullet_PNG_Transparent_Image_1;
            this.pb4.Location = new System.Drawing.Point(183, 165);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(51, 109);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 9;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::RussianRouletteGame.Properties.Resources.PNGPIX_COM_Bullet_PNG_Transparent_Image_1;
            this.pb3.Location = new System.Drawing.Point(126, 165);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(51, 109);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 8;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::RussianRouletteGame.Properties.Resources.PNGPIX_COM_Bullet_PNG_Transparent_Image_1;
            this.pb2.Location = new System.Drawing.Point(69, 165);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(51, 109);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 7;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Image = global::RussianRouletteGame.Properties.Resources.PNGPIX_COM_Bullet_PNG_Transparent_Image_1;
            this.pb1.Location = new System.Drawing.Point(12, 165);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(51, 109);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 6;
            this.pb1.TabStop = false;
            // 
            // pbTrump
            // 
            this.pbTrump.BackColor = System.Drawing.Color.Transparent;
            this.pbTrump.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTrump.Image = ((System.Drawing.Image)(resources.GetObject("pbTrump.Image")));
            this.pbTrump.Location = new System.Drawing.Point(12, 12);
            this.pbTrump.Name = "pbTrump";
            this.pbTrump.Size = new System.Drawing.Size(183, 140);
            this.pbTrump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrump.TabIndex = 5;
            this.pbTrump.TabStop = false;
            // 
            // pbRevolver
            // 
            this.pbRevolver.Image = ((System.Drawing.Image)(resources.GetObject("pbRevolver.Image")));
            this.pbRevolver.Location = new System.Drawing.Point(201, 54);
            this.pbRevolver.Name = "pbRevolver";
            this.pbRevolver.Size = new System.Drawing.Size(120, 68);
            this.pbRevolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRevolver.TabIndex = 4;
            this.pbRevolver.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtHiScore);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pbTrump);
            this.Controls.Add(this.pbRevolver);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Game";
            this.Text = " Russian Roulette";
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRevolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.PictureBox pbRevolver;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbTrump;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.RadioButton rbTrump;
        private System.Windows.Forms.RadioButton rbAway;
        private System.Windows.Forms.Button btnHiScores;
        private System.Windows.Forms.TextBox txtHiScore;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

