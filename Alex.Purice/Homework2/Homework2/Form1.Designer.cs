namespace Homework2
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
            this.testTextBoxLabel = new System.Windows.Forms.Label();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.testTextBoxAnother = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testTextBoxLabel
            // 
            this.testTextBoxLabel.AutoSize = true;
            this.testTextBoxLabel.Location = new System.Drawing.Point(13, 13);
            this.testTextBoxLabel.Name = "testTextBoxLabel";
            this.testTextBoxLabel.Size = new System.Drawing.Size(28, 13);
            this.testTextBoxLabel.TabIndex = 0;
            this.testTextBoxLabel.Text = "Test";
            this.testTextBoxLabel.Click += new System.EventHandler(this.testTextBoxLabel_Click);
            // 
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(16, 30);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(100, 20);
            this.testTextBox.TabIndex = 1;
            // 
            // testTextBoxAnother
            // 
            this.testTextBoxAnother.Location = new System.Drawing.Point(16, 57);
            this.testTextBoxAnother.Name = "testTextBoxAnother";
            this.testTextBoxAnother.Size = new System.Drawing.Size(100, 20);
            this.testTextBoxAnother.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.testTextBoxAnother);
            this.Controls.Add(this.testTextBox);
            this.Controls.Add(this.testTextBoxLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testTextBoxLabel;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.TextBox testTextBoxAnother;

    }
}

