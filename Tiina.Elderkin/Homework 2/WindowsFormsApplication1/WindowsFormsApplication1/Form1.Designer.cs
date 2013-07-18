using System;
using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.Windows.Forms;

namespace WindowsFormsApplication1
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
            this.MakeMeLaugh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // MakeMeLaugh
            // 
            this.MakeMeLaugh.Location = new System.Drawing.Point(30, 45);
            this.MakeMeLaugh.Name = "MakeMeLaugh";
            this.MakeMeLaugh.Size = new System.Drawing.Size(237, 111);
            this.MakeMeLaugh.TabIndex = 2;
            this.MakeMeLaugh.Text = "Whatever you do, don\'t click this!";
            this.MakeMeLaugh.UseVisualStyleBackColor = true;
            this.MakeMeLaugh.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(244, 250);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.MakeMeLaugh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }
        private void UpdateComponent()
        {
            string filepath = "../../Properties/light_explosion.gif";
            string[] messages = new string[] 
            { "Huh? " + Environment.NewLine + "I told you not to click it! " + Environment.NewLine + "Don't Click it AGAIN!",
                "Did you do that by accident?" + Environment.NewLine + "No more!",
                "Uh Oh. Most people will try their best so you may have a computer glitch! " + Environment.NewLine + "Better not click again or your computer might crash!",
                "Now you've done it!" + Environment.NewLine + "Your computer is wacking out!"
            };

            if (this.numericUpDown1.Value < messages.Length)
            {
                this.MakeMeLaugh.Text = messages[(int)this.numericUpDown1.Value];
            }
            this.numericUpDown1.UpButton();

            if (this.numericUpDown1.Value == messages.Length)
            {
                this.MakeMeLaugh.Size = new System.Drawing.Size(200,40);
                this.MakeMeLaugh.Location = new System.Drawing.Point(50,200);
                this.pictureBox1.Visible = true;
                this.pictureBox1.Image =  System.Drawing.Image.FromFile(filepath);
            }
            else if (this.numericUpDown1.Value > messages.Length)
            {
                //say goodbye
                Form1.ActiveForm.Close();
            }


          
            // 
            // Form1
            // 
            // this.ClientSize = new System.Drawing.Size(292, 273);
        }

        #endregion

        private System.Windows.Forms.Button MakeMeLaugh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

