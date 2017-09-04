using RussianRouletteGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RussianRouletteGame
{
    public partial class Startup : Form

        


    {
        public Startup()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Opens game and closes current page
            Game f1 = new Game();
            f1.Show();
            this.Visible = false;
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Opens help and closes startup screen
            Help h1 = new Help();
            h1.Show();
            this.Visible = false;
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits application
            Application.Exit();
        }

        private void btnHiScores_Click(object sender, EventArgs e)
        {
            // Opens High Scores and closes startup screen
            High_Scores hs = new High_Scores();
            hs.Show();
            this.Visible = false;
        }
     
    }
}
