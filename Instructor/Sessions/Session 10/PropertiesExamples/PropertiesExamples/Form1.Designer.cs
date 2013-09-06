namespace PropertiesExamples
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
            this.WholeNameLabel = new System.Windows.Forms.Label();
            this.AlphabetizedNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WholeNameLabel
            // 
            this.WholeNameLabel.AutoSize = true;
            this.WholeNameLabel.Location = new System.Drawing.Point(13, 13);
            this.WholeNameLabel.Name = "WholeNameLabel";
            this.WholeNameLabel.Size = new System.Drawing.Size(35, 13);
            this.WholeNameLabel.TabIndex = 0;
            this.WholeNameLabel.Text = "label1";
            // 
            // AlphabetizedNameLabel
            // 
            this.AlphabetizedNameLabel.AutoSize = true;
            this.AlphabetizedNameLabel.Location = new System.Drawing.Point(16, 58);
            this.AlphabetizedNameLabel.Name = "AlphabetizedNameLabel";
            this.AlphabetizedNameLabel.Size = new System.Drawing.Size(35, 13);
            this.AlphabetizedNameLabel.TabIndex = 1;
            this.AlphabetizedNameLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AlphabetizedNameLabel);
            this.Controls.Add(this.WholeNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WholeNameLabel;
        private System.Windows.Forms.Label AlphabetizedNameLabel;
    }
}

