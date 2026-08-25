using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04TaskPerformance1_Mandac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guessBtn(object sender, EventArgs e)
        {
            StringBuilder wrongGuesses = new StringBuilder(correctTxt.Text);

            string correctWord = "word";
            string word = answerBox.Text;

            if (word != correctWord)
            {
                WrongGuesses.Items.Add(word);
            }
            else if (word == correctWord)
            {
                correctTxt.Text = word;
            }
        }
    }
}
