using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceSimProject
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(Object sender, EventArgs e)
        {
            



        }
        public void DisplayDice()//method to determine the number of dice shown after roll button
        {
            if (oneDi.Checked == true)
                oneResult.Visible = true;

            if (twoDice.Checked == true)
            {
                oneResult.Visible = true;
                twoResult.Visible = true;
            }

            if (threeDice.Checked == true)
            {
                oneResult.Visible = true;
                twoResult.Visible = true;
                threeResult.Visible = true;
            }

            if (fourDice.Checked == true)
            {
                oneResult.Visible = true;
                twoResult.Visible = true;
                threeResult.Visible = true;
                fourResult.Visible = true;
            }
            if (fiveDice.Checked == true)
            {
                oneResult.Visible = true;
                twoResult.Visible = true;
                threeResult.Visible = true;
                fourResult.Visible = true;
                fiveResult.Visible = true;
            }
            if (sixDice.Checked == true)
            {
                oneResult.Visible = true;
                twoResult.Visible = true;
                threeResult.Visible = true;
                fourResult.Visible = true;
                fiveResult.Visible = true;
                sixResult.Visible = true;
            }
        }

        public void clearresults()
        {
            
            oneResult.Visible = false;
            twoResult.Visible = false;
            threeResult.Visible = false;
            fourResult.Visible = false;
            fiveResult.Visible = false;
            sixResult.Visible = false;

            oneResult.Text = "Roll1:";
            twoResult.Text = "Roll2:";
            threeResult.Text = "Roll3:";
            fourResult.Text = "Roll4:";
            fiveResult.Text = "Roll5:";
            sixResult.Text = "Roll6:";
        }//end clear results box 


        public void RollDice()//method to roll dice generates random numbers and assigns to labels for output
        {
            Random num = new Random();
            int one, two, three, four, five, six;
            one = num.Next(1, 7);
            two = num.Next(1, 7);
            three = num.Next(1, 7);
            four = num.Next(1, 7);
            five = num.Next(1, 7);
            six = num.Next(1, 7);
            int[] rollresults = { one, two, three, four, five, six };

            oneResult.Text = oneResult.Text + " " + rollresults[0];
            twoResult.Text = twoResult.Text + " " + rollresults[1];
            threeResult.Text = threeResult.Text + " " + rollresults[2];
            fourResult.Text = fourResult.Text + " " + rollresults[3];
            fiveResult.Text = fiveResult.Text + " " + rollresults[4];
            sixResult.Text = sixResult.Text + " " + rollresults[5];
        }

        private void Roll_Click(object sender, EventArgs e)
        {
            //if else determines if radio button checked for number of dice and throws message box if none selected
            if (oneDi.Checked == false && twoDice.Checked == false && threeDice.Checked == false && fourDice.Checked == false &&
                fiveDice.Checked == false && sixDice.Checked == false)
                MessageBox.Show("Please select a number of Dice");
            else
            {
                clearresults();
                RollDice();
                DisplayDice();
            }
            



                
        }

        private void button1_Click(object sender, EventArgs e)//clears results groupbox and resets label values
        {
        
            oneDi.Checked = true;
            oneResult.Visible = false;
            twoResult.Visible = false;
            threeResult.Visible = false;
            fourResult.Visible = false;
            fiveResult.Visible = false;
            sixResult.Visible = false;

            oneResult.Text = "Roll1:";
            twoResult.Text = "Roll2:";
            threeResult.Text = "Roll3";
            fourResult.Text = "Roll4";
            fiveResult.Text = "Roll5";
            sixResult.Text = "Roll6";
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }//roll click 
    }//end class
}//end namespace
