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
        int addent1;
        int addent2;

        public void StartTheQuiz()
        {
            addent1 = randomizer.Next(51);
            addent2 = randomizer.Next(51);

            plusLeftLabel.Text = addent1.ToString();
            plusRightLabel.Text = addent2.ToString();

            sum.Value = 0;
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
    }
}
