namespace Homework1
{
    partial class AlexHomework1Form
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
            this.trueProgrammerLabel = new System.Windows.Forms.Label();
            this.extraCreditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trueProgrammerLabel
            // 
            this.trueProgrammerLabel.AutoSize = true;
            this.trueProgrammerLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trueProgrammerLabel.Location = new System.Drawing.Point(129, 90);
            this.trueProgrammerLabel.Name = "trueProgrammerLabel";
            this.trueProgrammerLabel.Size = new System.Drawing.Size(281, 13);
            this.trueProgrammerLabel.TabIndex = 0;
            this.trueProgrammerLabel.Text = "No one but true programmers can change this line. Period.";
            // 
            // extraCreditButton
            // 
            this.extraCreditButton.Location = new System.Drawing.Point(188, 138);
            this.extraCreditButton.Name = "extraCreditButton";
            this.extraCreditButton.Size = new System.Drawing.Size(133, 34);
            this.extraCreditButton.TabIndex = 1;
            this.extraCreditButton.Text = "Go to Extra Credit Form";
            this.extraCreditButton.UseVisualStyleBackColor = true;
            this.extraCreditButton.Click += new System.EventHandler(this.goToExtraCreditButton_Click);
            // 
            // AlexHomework1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 255);
            this.Controls.Add(this.extraCreditButton);
            this.Controls.Add(this.trueProgrammerLabel);
            this.Name = "AlexHomework1Form";
            this.Text = "Alex P Homework 1 (Regular)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trueProgrammerLabel;
        private System.Windows.Forms.Button extraCreditButton;
    }
}

