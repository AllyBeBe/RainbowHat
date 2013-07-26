namespace ReferenceTypes
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.latestCutenessLabel = new System.Windows.Forms.Label();
            this.latestCuteness = new System.Windows.Forms.Label();
            this.previousCuteness = new System.Windows.Forms.Label();
            this.previousCutenessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make a Tiny";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Make It Cuter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // latestCutenessLabel
            // 
            this.latestCutenessLabel.AutoSize = true;
            this.latestCutenessLabel.Location = new System.Drawing.Point(221, 34);
            this.latestCutenessLabel.Name = "latestCutenessLabel";
            this.latestCutenessLabel.Size = new System.Drawing.Size(277, 26);
            this.latestCutenessLabel.TabIndex = 2;
            this.latestCutenessLabel.Text = "How cute is the latest Tiny?";
            // 
            // latestCuteness
            // 
            this.latestCuteness.AutoSize = true;
            this.latestCuteness.Location = new System.Drawing.Point(518, 34);
            this.latestCuteness.Name = "latestCuteness";
            this.latestCuteness.Size = new System.Drawing.Size(66, 26);
            this.latestCuteness.TabIndex = 3;
            this.latestCuteness.Text = "         ";
            // 
            // previousCuteness
            // 
            this.previousCuteness.AutoSize = true;
            this.previousCuteness.Location = new System.Drawing.Point(568, 103);
            this.previousCuteness.Name = "previousCuteness";
            this.previousCuteness.Size = new System.Drawing.Size(66, 26);
            this.previousCuteness.TabIndex = 5;
            this.previousCuteness.Text = "         ";
            // 
            // previousCutenessLabel
            // 
            this.previousCutenessLabel.AutoSize = true;
            this.previousCutenessLabel.Location = new System.Drawing.Point(221, 103);
            this.previousCutenessLabel.Name = "previousCutenessLabel";
            this.previousCutenessLabel.Size = new System.Drawing.Size(330, 26);
            this.previousCutenessLabel.TabIndex = 4;
            this.previousCutenessLabel.Text = "How cute was the previous Tiny?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 231);
            this.Controls.Add(this.previousCuteness);
            this.Controls.Add(this.previousCutenessLabel);
            this.Controls.Add(this.latestCuteness);
            this.Controls.Add(this.latestCutenessLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label latestCutenessLabel;
        private System.Windows.Forms.Label latestCuteness;
        private System.Windows.Forms.Label previousCuteness;
        private System.Windows.Forms.Label previousCutenessLabel;
    }
}

