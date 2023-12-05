using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        Random randomNumber = new Random();

        int number = 0;
        int guesses = 0;


        public Form1()
        {
            InitializeComponent();

            loadQuestions();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckNumber(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBoxNumber.Text);

            guesses += 1;
            lblGuessed.Text = "Ai incercat de " + guesses + " ori";

            if (i == number)
            {
                MessageBox.Show("Felicitari, ai ghicit numarul. Incearca dinnou!");
                loadQuestions();
                textBoxNumber.Text = "";
                guesses = 0;
                lblGuessed.Text = "Ai incercat de " + guesses + " ori";
            }
            else if (i < number)
            {
                MessageBox.Show("Mai mult");
            }
            else
            {
                MessageBox.Show("Mai putin");
            }


        }

        private void loadQuestions()
        {
            number = randomNumber.Next(0, 10);

            lblQuestion.Text = "Ma gandesc la un numar cuprins intre: 0 si 10";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
