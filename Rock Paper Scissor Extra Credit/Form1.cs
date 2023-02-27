using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissor_Extra_Credit
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
      
        //declare variables to store random numbers
        string computerChoice, userChoice;


        private void Form1_Load(object sender, EventArgs e)
        {

            //generate random number to determine computer choice
            computerChoice = generateNumber().ToString();
            
            


            //i can show that it is picking random numbers if i need to check 
            // computerChoiceOutput.Text = computerChoice.ToString();



            //this is my decision structure to determine which choice the computer has randomly picked
            if (computerChoice.Equals("1"))
            {
                computerChoice = "rock";

            }
            else if (computerChoice == "2")
            {
                computerChoice = "paper";

            }
            else
            {
                computerChoice = "scissors";

            }
           
        }


        private void rockButton_Click(object sender, EventArgs e)
        {
            //a conditional to make sure user cannot press a choice button more than once
            if (String.IsNullOrEmpty(userChoice))
            {


                //what's the user chose
                userChoice = "rock";
                //decision structure to determine who won the game
                if (computerChoice == "rock")
                {
                    outcomeOutputLabel.Text = "It is a draw. Play again.";
                    computerChoiceOutput.Text = "Rock";
                    computerChoicePictureBox.Image = myImageList.Images[1];
                }
                else if (computerChoice == "paper")
                {
                    outcomeOutputLabel.Text = "You lose! Paper wraps rock.";
                    computerChoiceOutput.Text = "Paper";
                    computerChoicePictureBox.Image = myImageList.Images[0];

                }
                else
                {
                    outcomeOutputLabel.Text = "You win! Rock smashes scissors.";
                    computerChoiceOutput.Text = "Scissors";
                    computerChoicePictureBox.Image = myImageList.Images[2];
                }
                //showing rock picture
                rockPictureBox.Image = myImageList.Images[1];
            }
            else
            {
                MessageBox.Show("Select new game or exit button");
            }

             

            
            

        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            //a conditional to make sure user cannot press a choice button more than once
            if (String.IsNullOrEmpty(userChoice))
            {


                //fill in with if user picks paper
                //what's the user chose
                userChoice = "paper";
                //decision structure to determine who won the game
                if (computerChoice == "rock")
                {
                    outcomeOutputLabel.Text = "You win! Paper wraps rock.";
                    computerChoiceOutput.Text = "Rock";
                    computerChoicePictureBox.Image = myImageList.Images[1];
                }
                else if (computerChoice == "paper")
                {
                    outcomeOutputLabel.Text = "It is a draw! Play again.";
                    computerChoiceOutput.Text = "Paper";
                    computerChoicePictureBox.Image = myImageList.Images[0];

                }
                else
                {
                    outcomeOutputLabel.Text = "You lose! Scissors cut paper. Try again.";
                    computerChoiceOutput.Text = "Scissors";
                    computerChoicePictureBox.Image = myImageList.Images[2];
                }
                //showing paper picture
                paperPictureBox.Image = myImageList.Images[0];
            }
            else
            {
                MessageBox.Show("Select new game or exit button");
            }
               
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            //a conditional to make sure user cannot press a choice button more than once
            if (String.IsNullOrEmpty(userChoice))
            {
                //what's the user chose
                userChoice = "scissor";
                //decision structure to determine who won the game
                if (computerChoice == "rock")
                {
                    outcomeOutputLabel.Text = "You lose! Rock breaks scissors. Try again.";
                    computerChoiceOutput.Text = "Rock";
                    computerChoicePictureBox.Image = myImageList.Images[1];

                }
                else if (computerChoice == "paper")
                {
                    outcomeOutputLabel.Text = "You win! Scissors cut paper.";
                    computerChoiceOutput.Text = "Paper";
                    computerChoicePictureBox.Image = myImageList.Images[0];


                }
                else
                {
                    outcomeOutputLabel.Text = "It is a draw! Try again.";
                    computerChoiceOutput.Text = "Scissors";
                    computerChoicePictureBox.Image = myImageList.Images[2];

                }
                //showing scissor picture
                scissorPictureBox.Image = myImageList.Images[2];

            }
            else
            {
                MessageBox.Show("Select new game or exit button");
            }
            
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            //restart game from here
            Application.Restart();
        }
       
       


        //define function to generate random number
        private int generateNumber()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 4);
            return randomNumber;
        }
    } 
}
 

