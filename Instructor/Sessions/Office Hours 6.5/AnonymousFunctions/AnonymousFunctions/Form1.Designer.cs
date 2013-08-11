namespace AnonymousFunctions
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
            this.doSomethingButton = new System.Windows.Forms.Button();
            this.clickMeLabel = new System.Windows.Forms.Label();
            this.secondButton = new System.Windows.Forms.Button();
            this.doSomethingElseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doSomethingButton
            // 
            this.doSomethingButton.Location = new System.Drawing.Point(13, 13);
            this.doSomethingButton.Name = "doSomethingButton";
            this.doSomethingButton.Size = new System.Drawing.Size(187, 23);
            this.doSomethingButton.TabIndex = 0;
            this.doSomethingButton.Text = "Do Something!";
            this.doSomethingButton.UseVisualStyleBackColor = true;
            this.doSomethingButton.Click += new System.EventHandler(this.DoSomethingButtonClick);
            // 
            // clickMeLabel
            // 
            this.clickMeLabel.AutoSize = true;
            this.clickMeLabel.Location = new System.Drawing.Point(12, 70);
            this.clickMeLabel.Name = "clickMeLabel";
            this.clickMeLabel.Size = new System.Drawing.Size(87, 13);
            this.clickMeLabel.TabIndex = 1;
            this.clickMeLabel.Text = "Click me, please!";
            this.clickMeLabel.Click += new System.EventHandler(this.DoSomethingButtonClick);
            // 
            // secondButton
            // 
            this.secondButton.Location = new System.Drawing.Point(207, 12);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(65, 60);
            this.secondButton.TabIndex = 2;
            this.secondButton.Text = "Second Button";
            this.secondButton.UseVisualStyleBackColor = true;
            // 
            // doSomethingElseButton
            // 
            this.doSomethingElseButton.Location = new System.Drawing.Point(13, 43);
            this.doSomethingElseButton.Name = "doSomethingElseButton";
            this.doSomethingElseButton.Size = new System.Drawing.Size(187, 23);
            this.doSomethingElseButton.TabIndex = 3;
            this.doSomethingElseButton.Text = "Do Something Else!";
            this.doSomethingElseButton.UseVisualStyleBackColor = true;
            this.doSomethingElseButton.Click += new System.EventHandler(this.DoSomethingButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.doSomethingElseButton);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.clickMeLabel);
            this.Controls.Add(this.doSomethingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doSomethingButton;
        private System.Windows.Forms.Label clickMeLabel;
        private System.Windows.Forms.Button secondButton;
        private System.Windows.Forms.Button doSomethingElseButton;
    }
}

