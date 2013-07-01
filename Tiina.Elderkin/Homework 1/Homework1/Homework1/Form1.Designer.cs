namespace Homework1
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
            this.textGrade = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textIn_Another = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.Text_PromptAnother = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textGrade
            // 
            this.textGrade.AutoSize = true;
            this.textGrade.Location = new System.Drawing.Point(13, 13);
            this.textGrade.Name = "textGrade";
            this.textGrade.Size = new System.Drawing.Size(220, 13);
            this.textGrade.TabIndex = 0;
            this.textGrade.Text = "A grade is only one measurement of success.";
            this.textGrade.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(64, 205);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(169, 23);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Homework #10 reworded";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.label1_Click);
            // 
            // textIn_Another
            // 
            this.textIn_Another.Location = new System.Drawing.Point(16, 65);
            this.textIn_Another.Name = "textIn_Another";
            this.textIn_Another.Size = new System.Drawing.Size(178, 20);
            this.textIn_Another.TabIndex = 2;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(200, 62);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(33, 23);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // Text_PromptAnother
            // 
            this.Text_PromptAnother.AutoSize = true;
            this.Text_PromptAnother.Location = new System.Drawing.Point(13, 49);
            this.Text_PromptAnother.Name = "Text_PromptAnother";
            this.Text_PromptAnother.Size = new System.Drawing.Size(88, 13);
            this.Text_PromptAnother.TabIndex = 5;
            this.Text_PromptAnother.Text = "What is another?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Text_PromptAnother);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textIn_Another);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.textGrade);
            this.Name = "Form1";
            this.Text = "Homework 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textGrade;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textIn_Another;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label Text_PromptAnother;
    }
}

