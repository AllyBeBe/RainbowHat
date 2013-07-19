namespace Homework2
{
    partial class Homework2
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
            this.AskMonkey = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Guess = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AskMonkey
            // 
            this.AskMonkey.Font = new System.Drawing.Font("SketchFlow Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AskMonkey.ForeColor = System.Drawing.Color.Maroon;
            this.AskMonkey.Location = new System.Drawing.Point(31, 26);
            this.AskMonkey.Name = "AskMonkey";
            this.AskMonkey.Size = new System.Drawing.Size(563, 54);
            this.AskMonkey.TabIndex = 1;
            this.AskMonkey.Text = "The monkey sees you are troubled. To seek his guidance enter your question into t" +
    "he following box.";
            this.AskMonkey.Click += new System.EventHandler(this.AskMonkey_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(215, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click here for his answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Guess
            // 
            this.Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guess.Location = new System.Drawing.Point(20, 98);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(574, 24);
            this.Guess.TabIndex = 3;
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Answer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Answer.Location = new System.Drawing.Point(17, 207);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(374, 280);
            this.Answer.TabIndex = 0;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Image = global::Homework2.Properties.Resources.smokingMonkey;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(397, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 290);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.Answer_Click);
            // 
            // Homework2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guess);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AskMonkey);
            this.Controls.Add(this.Answer);
            this.Name = "Homework2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AskMonkey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Guess;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Label label1;
    }
}

