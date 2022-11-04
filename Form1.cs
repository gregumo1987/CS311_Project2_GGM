using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_Project2_GGM
{
    public partial class frmMain : Form
    {
        private int pointValue;
        private int numberOfRolls;
        private int totalOutcome;
        private readonly float bankAmount;
        private float betAmount;
        private float bettingOutcome;

        public frmMain() => InitializeComponent();//end of frmMain

        private void lblRightDice_Click(object sender, EventArgs e)
        {

        }//end of lblRightDice_Click

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Calculate_Score(GetBankAmount());
        }//end of btnRoll_Click

        private void txtBet_TextChanged(object sender, EventArgs e)
        {
            betAmount = float.Parse(txtBet.Text);//change s string entered in bow to float
        }//end of txtBet_TextChanged

        private void lblOutcome_Click(object sender, EventArgs e)
        {

        }//end of lblOutcome_Click
        private void roll()
        {
            Random random = new Random();
            int leftDice = random.Next(1, 7);
            int rightDice = random.Next(1, 7);

            lblLeftDice.Text = leftDice.ToString();
            lblRightDice.Text = rightDice.ToString();
            totalOutcome = leftDice + rightDice;


        }//end roll method

        private float GetBankAmount()
        {
            return bankAmount;
        }

        private void Calculate_Score(float bankAmount)
        {
            bankAmount = float.Parse(lblBalance.Text);
            if (numberOfRolls == 0 && bankAmount>betAmount)
            {
                
                roll();
                switch (totalOutcome)
                {
                    case 2:
                        lblOutcome.Text = "you lose";
                        //need to minus txtbet with lblbalance- must clear pointvalue and 
                        bettingOutcome= bankAmount - betAmount;
                        lblBalance.Text = bettingOutcome.ToString("C");
                        break;

                    case 3:
                        lblOutcome.Text = "you lose";
                         bettingOutcome = bankAmount - betAmount;
                        lblBalance.Text = bettingOutcome.ToString("C");
                        //need to minus txtbet with lblbalance
                        break;
                    case 4:
                        lblOutcome.Text = "Point is " + totalOutcome;
                        numberOfRolls++;
                        pointValue = totalOutcome;

                        break;
                    case 5:
                        lblOutcome.Text = "Point is " + totalOutcome;
                        numberOfRolls++;
                        pointValue = totalOutcome;

                        break;
                    case 6:
                        lblOutcome.Text = "Point is " + totalOutcome;
                        numberOfRolls++;
                        pointValue = totalOutcome;
                        break;
                    case 7:
                        lblOutcome.Text = "You Win! ";
                         bettingOutcome = bankAmount + betAmount;
                        lblBalance.Text = bettingOutcome.ToString("C");
                        break;
                    case 8:
                        lblOutcome.Text = "Point is " + totalOutcome;
                        numberOfRolls++;
                        pointValue = totalOutcome;
                        break;
                    case 9:
                        lblOutcome.Text = "Point is " + totalOutcome;
                        numberOfRolls++;
                        pointValue = totalOutcome;
                        break;
                    case 10:
                        lblOutcome.Text = "Point is " + totalOutcome;
                        numberOfRolls++;
                        pointValue = totalOutcome;
                        break;
                    case 11:
                        lblOutcome.Text = "You Win!";

                        bettingOutcome = bankAmount + betAmount;
                        lblBalance.Text = bettingOutcome.ToString("C");
                        break;

                    case 12:
                        lblOutcome.Text = "you lose";
                        bettingOutcome = bankAmount + betAmount;
                        lblBalance.Text = bettingOutcome.ToString("C");
                        break;

                }//end switch statement
            }  //need else statement for condition when roll is greater than 0
            else if(numberOfRolls > 0 && bankAmount > betAmount)
            {
              
                roll();
                if (totalOutcome == pointValue)
                {
                    lblOutcome.Text = "You Win!";
                   bettingOutcome = bankAmount + betAmount;
                    lblBalance.Text = bettingOutcome.ToString("C");
                }//end if statement
                else if(totalOutcome ==7)
                {
                    lblOutcome.Text = "You lose!";
                    bettingOutcome = bankAmount - betAmount;
                    lblBalance.Text = bettingOutcome.ToString("C");
                }//end else statement

            }//end if statement
            else
            {
                lblBalance.Text = bettingOutcome.ToString("Insufficient funds");
            }

        }//end calculate_Score

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }
    }//end of class
}//end of namespace
