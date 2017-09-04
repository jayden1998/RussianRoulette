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
using System.Media;

namespace RussianRouletteGame
{


   

    public partial class Game : Form
    {
       // Declaring Variables
       int Shotcount = 6;
       int nextNumber;
       int ShootTrump = 0;
       Random bulletposn = new Random();
       public static string username;
       public static int score = 0;
       string path = @"\\telmar\users\JS082\Desktop\RussianRouletteGame\RussianRouletteGame\High Scores.csv";



        public Game()
        {
            InitializeComponent();
            

        }

        
        
        // Changes image depending on Radio button selected
        
        private void rbTrump_CheckedChanged(object sender, EventArgs e)
        {
            pbRevolver.Image = Properties.Resources.colt_revolver_pistol;
            btnFire.Enabled = true;
           

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pbRevolver.Image = Properties.Resources.colt_revolver_pistol1;
            btnFire.Enabled = true;
           
        }

        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            btnSpin.Enabled = true;
            
            // Calls audio file from resources folder and streams from soundplayer 
            System.IO.Stream str = Properties.Resources.Gun_Cocking_Slow_Mike_Koenig_1019236976;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit Event
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Restarts application
            System.Diagnostics.Process.Start(Application.ExecutablePath); //Start new instance of app
            Application.Exit(); //Turn off current app 
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            
            rbTrump.Enabled = true;
            rbAway.Enabled = true;

            // Calls audio file from resources folder and streams from soundplayer 
            System.IO.Stream str = Properties.Resources.RevolverSpin;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

            // Generates random number between 1 and 7 
            nextNumber= bulletposn.Next(1, 7);
           
        }

        
        private void btnFire_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.pistol_shot;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();


            // Disables Buttons once btnFire is clicked
            btnSpin.Enabled = false;
            btnLoad.Enabled = false;

            // Makes PictureBox invisible everytime Fire button is pressed. 
            Shotcount = Shotcount - 1;

            if (Shotcount == 5)
            {
                pb1.Visible = !pb1.Visible;

            }
            else if (Shotcount == 4)
            {
                pb2.Visible = !pb2.Visible;
            }
            else if (Shotcount == 3)
            {
                pb3.Visible = !pb3.Visible;
            }
            else if (Shotcount == 2)
            {
                pb4.Visible = !pb4.Visible;
            }
            else if (Shotcount == 1)
            {
                pb5.Visible = !pb5.Visible;
            }
            else if (Shotcount == 0)
            {
                pb6.Visible = !pb6.Visible;
                                          

            }

          

            
            
           
            // Game logic follows

            // Disables RadioButton after 2 attempts at Trump are used
            if (rbTrump.Checked)
            {
               ShootTrump = ShootTrump + 1;              
            }
            if (ShootTrump == 2)
            {
                rbTrump.Enabled = false;
                rbAway.Checked = true;
            }




            // Displays message box, stating if you win or lose. 
            // Play again message box
            // Submitts HiScores 
            username = txtUser.Text;
            if (nextNumber == Shotcount && rbAway.Checked)
            {
                score = score - 1;
                txtHiScore.Text = score.ToString();
                

                MessageBox.Show("You lose, you didn't complete the assasination.");

                // Play again messageBox
                if (MessageBox.Show("Play again?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // If yes is clicked
                    // Calls funtion
                    Fresh();
                }
                else
                {
                    // if no is clicked
                    // Takes you to main menu and submitts score
                    if (File.Exists(path))
                    {
                        //Create a new file if it doesn't exist, and add it to it
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine(username + "," + score);
                        }

                    }
                    else
                    {
                        // Append to the file
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine(username + "," + score);
                        }
                    }
                    System.Diagnostics.Process.Start(Application.ExecutablePath); //Start new instance of app
                    Application.Exit(); //Turn off current app 
                }

            }
            else if (nextNumber == Shotcount && rbTrump.Checked)
            {
                score = score + 1;
                txtHiScore.Text = score.ToString();

                MessageBox.Show("You win, your target has been executed.");

                // Play again messageBox
                if (MessageBox.Show("Play again?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // If yes is clicked
                    // Calls function                   
                   Fresh();
                }
                else
                {
                    // if no is clicked
                    // Takes you to main menu and submitts score
                    if (File.Exists(path))
                    {
                        //Create a new file if it doesn't exist, and add it to it
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine(username + "," + score);
                        }

                    }
                    else
                    {
                        // Append to the file
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine(username + "," + score);
                        }
                    }
                    System.Diagnostics.Process.Start(Application.ExecutablePath); //Start new instance of app
                    Application.Exit(); //Turn off current app 
                }

            }

           
            
            

           












        }

        
        private void Game_Load(object sender, EventArgs e)
        {
            // Disabled buttons on form load
            btnSpin.Enabled = false;
            rbTrump.Enabled = false;
            rbAway.Enabled = false;
            btnFire.Enabled = false;
        }

        public void Fresh()
        {
            Shotcount = 6;
            ShootTrump = 0;                      
            btnLoad.Enabled = true;
            rbAway.Enabled = true;
            rbTrump.Enabled = true;
            pb1.Visible = true;
            pb2.Visible = true;
            pb3.Visible = true;
            pb4.Visible = true;
            pb5.Visible = true;
            pb6.Visible = true;
            rbTrump.Enabled = false;
            rbAway.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHiScores_Click(object sender, EventArgs e)
        {
            High_Scores hs = new High_Scores();
            hs.Show();
            this.Visible = false;
        }
    }
}
