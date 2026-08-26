using System;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _04TaskPerformance1_Mandac
{
    public partial class frmGuessWord : Form
    {
        private string[] correctWords = { "word", "next", "computer", "hello" };
        private int currentIndex = 0;
        private bool isCorrect = false;
        ArrayList wrongGuessList = new ArrayList();
        public frmGuessWord()
        {
            InitializeComponent();
        }

        private void guessBtn(object sender, EventArgs e)
        {
            string word = answerBox.Text.Trim().ToLower();

            if (!isCorrect)
            {
                if (string.IsNullOrEmpty(word) || string.IsNullOrWhiteSpace(word))
                {
                    emptyBox.Text = "Please enter a word.";
                    emptyBox.ForeColor = Color.Red;
                    answerBox.Clear();
                    answerBox.Focus();
                    return;
                }

                if (word == correctWords[currentIndex])
                {
                    correctTxt.Text = word;
                    isCorrect = true;

                    if (currentIndex < correctWords.Length - 1)
                    {
                        GuessBtn.Text = "Next word";
                        emptyBox.Text = "Correct!";
                        emptyBox.ForeColor = Color.Black;
                        MessageBox.Show("Correct guess!", "Correct Guess", MessageBoxButtons.OK);
                    }
                    
                    else
                    {
                        GuessBtn.Text = "Play Again";
                        currentIndex = -1;
                        emptyBox.Text = "Correct!";
                        emptyBox.ForeColor = Color.Black;
                        MessageBox.Show("Correct guess!", "Correct Guess", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    wrongGuessList.Add(word);

                    WrongGuesses.Items.Clear();
                    foreach (string guesses in wrongGuessList)
                    {
                        WrongGuesses.Items.Add(guesses);
                    }

                    answerBox.Clear();
                    emptyBox.Text = "Try again.";
                    emptyBox.ForeColor = Color.Red;
                    MessageBox.Show("Incorrect guess. \ntry again.", "Incorrect Guess", MessageBoxButtons.OK);
                }
            }  
            else 
            {
                currentIndex++;
                if(currentIndex < correctWords.Length)
                {
                    StringBuilder hintWords = new StringBuilder();
                    string targerWord = correctWords[currentIndex];

                    for (int i = 0; i < targerWord.Length; i++)
                    {
                        if (i == 0 || i == targerWord.Length - 1)
                        {
                            hintWords.Append(targerWord[i]);
                        }
                        else
                        {
                            hintWords.Append(" _ ");
                        }
                    }

                    correctTxt.Text = hintWords.ToString().Trim().ToLower();
                    GuessBtn.Text = "Guess";
                    emptyBox.Text = "";
                    answerBox.Clear();
                    WrongGuesses.Items.Clear();
                    isCorrect = false;
                }
            }            
        }

        private void StartBtn(object sender, EventArgs e)
        {
            startPanel.Visible = false;
        }
    }
}