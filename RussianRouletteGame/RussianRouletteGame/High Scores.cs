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


    public partial class High_Scores : Form


    {
        public High_Scores()
        {
            InitializeComponent();
        }


        // Variables
        string path = @"\\telmar\users\JS082\Desktop\RussianRouletteGame\RussianRouletteGame\High Scores.csv";

        private void button1_Click(object sender, EventArgs e)
        {
            // Reopens Startup screen, closes High scores.
            Startup s1 = new Startup();
            s1.Show();
            this.Visible = false;
        }

        private void High_Scores_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                // then read it

                using (StreamReader sr = new StreamReader(path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] split = line.Split(',');
                        dataGridView1.Rows.Add(split[0], split[1]);
                    }
                }
            }

        }
    }
}
