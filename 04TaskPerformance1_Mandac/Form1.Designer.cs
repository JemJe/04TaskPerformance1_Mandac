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
            this.emptyBox = new System.Windows.Forms.Label();
            this.startPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.startPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // correctTxt
            // 
            this.correctTxt.BackColor = System.Drawing.Color.Linen;
            this.correctTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.correctTxt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.correctTxt.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.correctTxt.Location = new System.Drawing.Point(22, 60);
            this.correctTxt.Name = "correctTxt";
            this.correctTxt.Padding = new System.Windows.Forms.Padding(1);
            this.correctTxt.Size = new System.Drawing.Size(528, 90);
            this.correctTxt.TabIndex = 0;
            this.correctTxt.Text = "w _ _ d";
            this.correctTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerBox
            // 
            this.answerBox.BackColor = System.Drawing.Color.White;
            this.answerBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.answerBox.Location = new System.Drawing.Point(22, 253);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(359, 32);
            this.answerBox.TabIndex = 1;
            // 
            // wrongGuess
            // 
            this.wrongGuess.BackColor = System.Drawing.Color.Linen;
            this.wrongGuess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wrongGuess.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongGuess.ForeColor = System.Drawing.SystemColors.Desktop;
            this.wrongGuess.Location = new System.Drawing.Point(22, 315);
            this.wrongGuess.Name = "wrongGuess";
            this.wrongGuess.Padding = new System.Windows.Forms.Padding(1);
            this.wrongGuess.Size = new System.Drawing.Size(528, 33);
            this.wrongGuess.TabIndex = 2;
            this.wrongGuess.Text = "Wrong Guess";
            this.wrongGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuessBtn
            // 
            this.GuessBtn.BackColor = System.Drawing.Color.Tan;
            this.GuessBtn.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.GuessBtn.FlatAppearance.BorderSize = 2;
            this.GuessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuessBtn.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GuessBtn.Location = new System.Drawing.Point(387, 253);
            this.GuessBtn.Name = "GuessBtn";
            this.GuessBtn.Size = new System.Drawing.Size(163, 32);
            this.GuessBtn.TabIndex = 4;
            this.GuessBtn.Text = "Guess";
            this.GuessBtn.UseVisualStyleBackColor = false;
            this.GuessBtn.Click += new System.EventHandler(this.guessBtn);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(22, -3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1);
            this.label2.Size = new System.Drawing.Size(528, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Guess the word!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(22, 224);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(267, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter your guessed word here";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WrongGuesses
            // 
            this.WrongGuesses.BackColor = System.Drawing.Color.Linen;
            this.WrongGuesses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WrongGuesses.FormattingEnabled = true;
            this.WrongGuesses.Location = new System.Drawing.Point(22, 341);
            this.WrongGuesses.Name = "WrongGuesses";
            this.WrongGuesses.Size = new System.Drawing.Size(528, 91);
            this.WrongGuesses.TabIndex = 7;
            // 
            // emptyBox
            // 
            this.emptyBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emptyBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.emptyBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emptyBox.Location = new System.Drawing.Point(22, 288);
            this.emptyBox.Name = "emptyBox";
            this.emptyBox.Padding = new System.Windows.Forms.Padding(1);
            this.emptyBox.Size = new System.Drawing.Size(258, 26);
            this.emptyBox.TabIndex = 8;
            this.emptyBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.label4);
            this.startPanel.Controls.Add(this.label1);
            this.startPanel.Controls.Add(this.button1);
            this.startPanel.Location = new System.Drawing.Point(-4, -3);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(581, 454);
            this.startPanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(67, 63);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(487, 127);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(171, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.StartBtn);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(236, 190);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(1);
            this.label4.Size = new System.Drawing.Size(105, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Guessing game";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(573, 444);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.emptyBox);
            this.Controls.Add(this.WrongGuesses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GuessBtn);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.correctTxt);
            this.Controls.Add(this.wrongGuess);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
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
        private System.Windows.Forms.Label emptyBox;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

