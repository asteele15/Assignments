using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _730NumberGuessing
{
    public partial class Form1 : Form
    {
        int Random1;    

        public void Form()
        {
            InitializeComponent();
        }
    
        public void btnStart_Click(object sender, EventArgs e)
        {
            //generate random number
            int Random1;
            Random1 = Program.Random();

            //show game functions
            btnGuess.Visible = true; 
            label2.Visible = true;
            btnReplay.Visible = true;
            btnExit.Visible = true;
            lblAnswer.Visible = true;
            lblGuesses.Visible = true;
            

            
        }

        public void btnGuess_Click(object sender, EventArgs e)
        {
            int Guess;
            
            do
            {
                Guess = Convert.ToInt32(userinput.Text); // convert guess to integer


                //test integer with random to determine if correct
                if (Guess == Random1)
                    lblAnswer.Text = ("Congrats! You guessed right!");
                else if (Guess < Random1)
                {   
                    lblAnswer.Text = ("Your guess is too low, try again.");
                    lblGuesses.Text = lblGuesses.Text + Convert.ToString(Guess);
                }
                else if (Guess > Random1)
                {
                    lblAnswer.Text = ("Your guess is too high, try again.");
                    lblGuesses.Text = lblGuesses.Text + Convert.ToString(Guess);
                }
            } while (Guess != Random1);
            
        }//end start click
    
    }//end class
} //end namespace
