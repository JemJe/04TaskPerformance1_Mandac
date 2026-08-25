namespace _04TaskPerformance1_Mandac
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.correctTxt = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.wrongGuess = new System.Windows.Forms.Label();
            this.GuessBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WrongGuesses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // correctTxt
            // 
            this.correctTxt.BackColor = System.Drawing.Color.Linen;
            this.correctTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.correctTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.correctTxt.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.correctTxt.Location = new System.Drawing.Point(12, 85);
            this.correctTxt.Name = "correctTxt";
            this.correctTxt.Padding = new System.Windows.Forms.Padding(1);
            this.correctTxt.Size = new System.Drawing.Size(776, 90);
            this.correctTxt.TabIndex = 0;
            this.correctTxt.Text = "w _ _ d";
            this.correctTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerBox
            // 
            this.answerBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.answerBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.answerBox.Location = new System.Drawing.Point(12, 213);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(614, 32);
            this.answerBox.TabIndex = 1;
            // 
            // wrongGuess
            // 
            this.wrongGuess.BackColor = System.Drawing.Color.Linen;
            this.wrongGuess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wrongGuess.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongGuess.ForeColor = System.Drawing.SystemColors.Desktop;
            this.wrongGuess.Location = new System.Drawing.Point(12, 317);
            this.wrongGuess.Name = "wrongGuess";
            this.wrongGuess.Padding = new System.Windows.Forms.Padding(1);
            this.wrongGuess.Size = new System.Drawing.Size(776, 26);
            this.wrongGuess.TabIndex = 2;
            this.wrongGuess.Text = "Wrong Guess";
            this.wrongGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuessBtn
            // 
            this.GuessBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.GuessBtn.Font = new System.Drawing.Font("Linux Libertine Display G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessBtn.Location = new System.Drawing.Point(632, 213);
            this.GuessBtn.Name = "GuessBtn";
            this.GuessBtn.Size = new System.Drawing.Size(156, 33);
            this.GuessBtn.TabIndex = 4;
            this.GuessBtn.Text = "Guess";
            this.GuessBtn.UseVisualStyleBackColor = false;
            this.GuessBtn.Click += new System.EventHandler(this.guessBtn);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(143, 8);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1);
            this.label2.Size = new System.Drawing.Size(516, 77);
            this.label2.TabIndex = 5;
            this.label2.Text = "Guess the word!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(267, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter your guessed word here";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WrongGuesses
            // 
            this.WrongGuesses.FormattingEnabled = true;
            this.WrongGuesses.Location = new System.Drawing.Point(12, 346);
            this.WrongGuesses.Name = "WrongGuesses";
            this.WrongGuesses.Size = new System.Drawing.Size(776, 95);
            this.WrongGuesses.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WrongGuesses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GuessBtn);
            this.Controls.Add(this.wrongGuess);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.correctTxt);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label correctTxt;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label wrongGuess;
        private System.Windows.Forms.Button GuessBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox WrongGuesses;
    }
}

