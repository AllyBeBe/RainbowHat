namespace Collections
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
            this.makeThingy = new System.Windows.Forms.Button();
            this.frobLatest = new System.Windows.Forms.Button();
            this.numberOfThingies = new System.Windows.Forms.Label();
            this.valueOfLatestThingy = new System.Windows.Forms.Label();
            this.listOfThingies = new System.Windows.Forms.Label();
            this.largestThingy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // makeThingy
            // 
            this.makeThingy.Location = new System.Drawing.Point(13, 13);
            this.makeThingy.Name = "makeThingy";
            this.makeThingy.Size = new System.Drawing.Size(132, 23);
            this.makeThingy.TabIndex = 0;
            this.makeThingy.Text = "Make a New Thingy";
            this.makeThingy.UseVisualStyleBackColor = true;
            this.makeThingy.Click += new System.EventHandler(this.makeThingy_Click);
            // 
            // frobLatest
            // 
            this.frobLatest.Location = new System.Drawing.Point(13, 43);
            this.frobLatest.Name = "frobLatest";
            this.frobLatest.Size = new System.Drawing.Size(146, 23);
            this.frobLatest.TabIndex = 1;
            this.frobLatest.Text = "Frob the Latest Thingy";
            this.frobLatest.UseVisualStyleBackColor = true;
            this.frobLatest.Click += new System.EventHandler(this.frobLatest_Click);
            // 
            // numberOfThingies
            // 
            this.numberOfThingies.AutoSize = true;
            this.numberOfThingies.Location = new System.Drawing.Point(13, 73);
            this.numberOfThingies.Name = "numberOfThingies";
            this.numberOfThingies.Size = new System.Drawing.Size(46, 13);
            this.numberOfThingies.TabIndex = 2;
            this.numberOfThingies.Text = "             ";
            // 
            // valueOfLatestThingy
            // 
            this.valueOfLatestThingy.AutoSize = true;
            this.valueOfLatestThingy.Location = new System.Drawing.Point(16, 90);
            this.valueOfLatestThingy.Name = "valueOfLatestThingy";
            this.valueOfLatestThingy.Size = new System.Drawing.Size(55, 13);
            this.valueOfLatestThingy.TabIndex = 3;
            this.valueOfLatestThingy.Text = "                ";
            // 
            // listOfThingies
            // 
            this.listOfThingies.AutoSize = true;
            this.listOfThingies.Location = new System.Drawing.Point(19, 134);
            this.listOfThingies.Name = "listOfThingies";
            this.listOfThingies.Size = new System.Drawing.Size(40, 13);
            this.listOfThingies.TabIndex = 4;
            this.listOfThingies.Text = "           ";
            // 
            // largestThingy
            // 
            this.largestThingy.AutoSize = true;
            this.largestThingy.Location = new System.Drawing.Point(13, 107);
            this.largestThingy.Name = "largestThingy";
            this.largestThingy.Size = new System.Drawing.Size(37, 13);
            this.largestThingy.TabIndex = 5;
            this.largestThingy.Text = "          ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.largestThingy);
            this.Controls.Add(this.listOfThingies);
            this.Controls.Add(this.valueOfLatestThingy);
            this.Controls.Add(this.numberOfThingies);
            this.Controls.Add(this.frobLatest);
            this.Controls.Add(this.makeThingy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeThingy;
        private System.Windows.Forms.Button frobLatest;
        private System.Windows.Forms.Label numberOfThingies;
        private System.Windows.Forms.Label valueOfLatestThingy;
        private System.Windows.Forms.Label listOfThingies;
        private System.Windows.Forms.Label largestThingy;
    }
}

