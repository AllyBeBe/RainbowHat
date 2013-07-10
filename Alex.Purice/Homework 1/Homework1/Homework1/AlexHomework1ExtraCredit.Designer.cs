namespace Homework1
{
    partial class AlexHomework1ExtraCredit
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
            this.extraCreditButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.superDuperExtraCreditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // extraCreditButton
            // 
            this.extraCreditButton.Location = new System.Drawing.Point(199, 102);
            this.extraCreditButton.Name = "extraCreditButton";
            this.extraCreditButton.Size = new System.Drawing.Size(179, 23);
            this.extraCreditButton.TabIndex = 0;
            this.extraCreditButton.Text = "I\'m Extra Credit Button. Click me.";
            this.extraCreditButton.UseVisualStyleBackColor = true;
            this.extraCreditButton.Click += new System.EventHandler(this.showExtraCreditMessage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Extra credit functionality.";
            // 
            // superDuperExtraCreditButton
            // 
            this.superDuperExtraCreditButton.Location = new System.Drawing.Point(199, 132);
            this.superDuperExtraCreditButton.Name = "superDuperExtraCreditButton";
            this.superDuperExtraCreditButton.Size = new System.Drawing.Size(179, 52);
            this.superDuperExtraCreditButton.TabIndex = 2;
            this.superDuperExtraCreditButton.Text = "Please Click Here to Check Super-Duper Extra Credit.";
            this.superDuperExtraCreditButton.UseVisualStyleBackColor = true;
            this.superDuperExtraCreditButton.Visible = false;
            this.superDuperExtraCreditButton.Click += new System.EventHandler(this.superDuperExtraCreditButton_Click);
            // 
            // AlexHomework1ExtraCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(586, 329);
            this.Controls.Add(this.superDuperExtraCreditButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extraCreditButton);
            this.HelpButton = true;
            this.Name = "AlexHomework1ExtraCredit";
            this.Text = "Alex P Homework 1 Extra Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button extraCreditButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button superDuperExtraCreditButton;
    }
}