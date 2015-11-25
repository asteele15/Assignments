using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessing
{
    public partial class Form1 : Form

    {
         //generate random number
            
            int Random1 = Program.Random();        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           

            //show game functions
            btnGuess.Visible = true;
            label2.Visible = true;
            btnReplay.Visible = true;
            btnExit.Visible = true;
            lblAnswer.Visible = true;
            lblGuesses.Visible = true;
            userinput.Visible = true;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int Guess;
            

            
                Guess = Convert.ToInt32(userinput.Text); // convert guess to integer


                //test integer with random to determine if correct
                if (Guess == Random1)
                {
                    lblAnswer.Text = ("Congrats! You guessed right!");
                    lblGuesses.BackColor = Color.Green;
                    lblAnswer.ForeColor = Color.Green;
                }
                else if (Guess < Random1)
                {
                    lblAnswer.Text = ("Your guess is too low, try again.");
                    lblAnswer.ForeColor = Color.CornflowerBlue;
                    lblGuesses.Text = lblGuesses.Text + Convert.ToString(Guess);
                    lblGuesses.BackColor = Color.CornflowerBlue;
                }
                else if (Guess > Random1)
                {
                    lblAnswer.Text = ("Your guess is too high, try again.");
                    lblAnswer.ForeColor = Color.PaleVioletRed;
                    lblGuesses.Text = lblGuesses.Text + Convert.ToString(Guess + " :");
                    lblGuesses.BackColor = Color.PaleVioletRed;
                }
            
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            Random1 = Program.Random();
            lblGuesses.Text = ("Attempted Guesses:");
            lblGuesses.BackColor = Color.Empty;
            userinput.Text = ("");
            lblAnswer.ForeColor = Color.Empty;
            lblAnswer.Text = ("");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
