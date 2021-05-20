using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RPS
{
    public partial class Form1 : Form
    {
        // variables
        int rounds = 3;
        int timePerRound = 6;
        bool gameOver = false;

        // string array for the three random choices, added each twice to increase the randomness. 0 is rock, 5 is rock
        string[] CPUChoiceList = {"rock", "paper", "scissor", "paper", "scissor", "rock"};

        int randomNumber = 0;

        // choices
        string CPUChoice;
        string PlayerChoice;

        // determines the scores
        int PlayerScore;
        int CPUScore;


        // class to use for the random class
        Random rnd = new Random();

        // constructor
        public Form1()
        {
            InitializeComponent();

            CountDownTimer.Enabled = true;

            PlayerChoice = "none";

            textcountdown.Text = "5";
        }

        // when the rock button is clicked, this will happen
        private void buttonrock_Click(object sender, EventArgs e)
        {
            //when pressed the picture will display the rock from the below file
            pictureplayer.Image = Properties.Resources.rock;
            PlayerChoice = "rock";
        }

        private void buttonpaper_Click(object sender, EventArgs e)
        {
            //when pressed the picture will display the paper from the below file
            pictureplayer.Image = Properties.Resources.paper;
            PlayerChoice = "paper";
        }

        private void buttonscissors_Click(object sender, EventArgs e)
        {
            //when pressed the picture will display the scissors from the below file
            pictureplayer.Image = Properties.Resources.scissors;
            PlayerChoice = "scissor";

        }

        // when the player clicks the restart button the below will happen
        private void buttonrestart_Click(object sender, EventArgs e)
        {
            PlayerScore = 0;
            CPUScore = 0;
            rounds = 3;

            //this text box will appear - player score + cpu score
            textscore.Text = "Player: " + PlayerScore + " - " + "CPU: " + CPUScore;

            PlayerChoice = "none";

            CountDownTimer.Enabled = true;

            pictureplayer.Image = Properties.Resources.questionmark;
            picturecpu.Image = Properties.Resources.questionmark;

            gameOver = false;
        }

        //beginning of the game
        private void CountDownTimerEvent(object sender, EventArgs e)
        {
            //timer goes down by 1 second
            timePerRound -= 1;

            textcountdown.Text = timePerRound.ToString();

            // keeps score and displays the round
            textrounds.Text = "Rounds: " + rounds;

            // if the time per round drops below 1, the countdown timer stops, CPU chooses a random number from 0-5, this is assigned to either rock, paper or scissors
            if (timePerRound < 1)
            {
                CountDownTimer.Enabled = false;

                timePerRound = 6;

                randomNumber = rnd.Next(0, CPUChoiceList.Length);

                CPUChoice = CPUChoiceList[randomNumber];

                //cpu images link to the random selection. switch statement
                switch (CPUChoice)
                {
                    case "rock":
                        picturecpu.Image = Properties.Resources.rock;
                        break;

                    case "paper":
                        picturecpu.Image = Properties.Resources.paper;
                        break;

                    case "scissor":
                        picturecpu.Image = Properties.Resources.scissors;
                        break;
                }

                // if theres 0 rounds left in the game, the below if statement will run
                if (rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    if(PlayerScore > CPUScore)
                    {
                        MessageBox.Show("You Win");
                    }
                    else
                    {
                        MessageBox.Show("Computer wins");
                    }

                    gameOver = true;
                }
            }

             

        }


            //rules of the game
            private void checkGame()
            {
                if(PlayerChoice == "rock" && CPUChoice == "paper")
                {
                    CPUScore += 1;

                    rounds -= 1;

                    MessageBox.Show("CPU Wins, Paper beats Rock");
                }
                else if (PlayerChoice == "scissor" && CPUChoice == "rock")
                {
                    CPUScore += 1;

                    rounds -= 1;

                    MessageBox.Show("CPU Wins, Rock beats Scissor");
                }
                else if (PlayerChoice == "paper" && CPUChoice == "scissor")
                {
                    CPUScore += 1;

                    rounds -= 1;

                    MessageBox.Show("CPU Wins, Scissors beats Paper");
                }
                else if (PlayerChoice == "rock" && CPUChoice == "scissor")
                {
                    PlayerScore += 1;

                    rounds -= 1;

                    MessageBox.Show("You win, Rock beats Scissor");
                }
                else if (PlayerChoice == "paper" && CPUChoice == "rock")
                {
                    PlayerScore += 1;
                  

                    rounds -= 1;

                    MessageBox.Show("You win, Paper beats Rock");
                }
                else if (PlayerChoice == "scissor" && CPUChoice == "paper")
                {
                    PlayerScore += 1;

                    rounds -= 1;

                    MessageBox.Show("You win, Scissor beats Paper");
                }

                //if the player doesn't make a choice in time
                else if (PlayerChoice == "none")
                {
                    MessageBox.Show("Please make a choice");
                }

                //if NONE of these are met, its a draw
                else
                {
                    MessageBox.Show("It's a draw");
                }

            startNextRound();
            }

            //class for the next round, if the game is over, this will activate
        private void startNextRound()
        {
            if(gameOver == true)
            {
                return;
            }

            textscore.Text = "Player: " + PlayerScore + " - " + "CPU: " + CPUScore;

            PlayerChoice = "none";

            CountDownTimer.Enabled = true;

            pictureplayer.Image = Properties.Resources.questionmark;
            picturecpu.Image = Properties.Resources.questionmark;

        }


        }
    }

