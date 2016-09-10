using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_mathematical_puzzle
{
    public partial class Form1 : Form
    {
        //Create random object called randomizer
        //to generate random numbers.
        Random randomizer = new Random();
        
        int addend1;
        int addend2;

        int timeLeft;
        
        int minuend;
        int subtrahend;


        private bool CheckTheAnswer()
        {

            if ((addend1 + addend2 == sum.Value)
                &&(minuend - subtrahend == difference.Value))
                return true;
            else
                return false;
        }
        public void StartTheQuiz()
        {

            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            sum.Value = 0;

            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;


            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();

        }



        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void sum_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the time left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + "seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Tim`s up";
                MessageBox.Show("You didn`t finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lenghtOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }
        }
    }
}
