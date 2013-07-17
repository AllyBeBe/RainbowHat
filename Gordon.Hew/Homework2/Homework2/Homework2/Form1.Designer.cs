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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.greetingButton = new System.Windows.Forms.Button();
            this.laughCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.nameTextBox.Location = new System.Drawing.Point(85, 10);
            this.nameTextBox.Name = "textBox1";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GreetingButton
            // 
            this.greetingButton.Location = new System.Drawing.Point(59, 111);
            this.greetingButton.Name = "GreetingButton";
            this.greetingButton.Size = new System.Drawing.Size(75, 23);
            this.greetingButton.TabIndex = 2;
            this.greetingButton.Text = "Greet Me";
            this.greetingButton.UseVisualStyleBackColor = true;
            this.greetingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // laughCheckBox
            // 
            this.laughCheckBox.AutoSize = true;
            this.laughCheckBox.Location = new System.Drawing.Point(16, 36);
            this.laughCheckBox.Name = "laughCheckBox";
            this.laughCheckBox.Size = new System.Drawing.Size(123, 17);
            this.laughCheckBox.TabIndex = 3;
            this.laughCheckBox.Text = "Make Mickey Laugh";
            this.laughCheckBox.UseVisualStyleBackColor = true;
            this.laughCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 146);
            this.Controls.Add(this.laughCheckBox);
            this.Controls.Add(this.greetingButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Homework 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button greetingButton;
        private System.Windows.Forms.CheckBox laughCheckBox;
    }
}

