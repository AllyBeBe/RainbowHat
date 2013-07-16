namespace WeightInGold
{
    partial class frmWeightInGold
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
            this.linkLblGoldPriceOrg = new System.Windows.Forms.LinkLabel();
            this.cmdCalculateWeightInGold = new System.Windows.Forms.Button();
            this.txtGoldPrice = new System.Windows.Forms.TextBox();
            this.txtUserWeight = new System.Windows.Forms.TextBox();
            this.lblPriceOfGold = new System.Windows.Forms.Label();
            this.lblEnterWeight = new System.Windows.Forms.Label();
            this.imgGoldBars = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgGoldBars)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLblGoldPriceOrg
            // 
            this.linkLblGoldPriceOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // EDIT: Modified LinkArea(x,y) to define which part of text to be hotlinked where x: character
            // position to begin hotlinking and y: number of characters to right of starting character to hotlink
            this.linkLblGoldPriceOrg.LinkArea = new System.Windows.Forms.LinkArea(6, 4);
            this.linkLblGoldPriceOrg.Location = new System.Drawing.Point(302, 127);
            this.linkLblGoldPriceOrg.Name = "linkLblGoldPriceOrg";
            this.linkLblGoldPriceOrg.Size = new System.Drawing.Size(196, 59);
            this.linkLblGoldPriceOrg.TabIndex = 8;
            this.linkLblGoldPriceOrg.TabStop = true;
            this.linkLblGoldPriceOrg.Text = "Click here to look-up the current price of Gold";
            this.linkLblGoldPriceOrg.UseCompatibleTextRendering = true;
            this.linkLblGoldPriceOrg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblGoldPriceOrg_LinkClicked);
            // 
            // cmdCalculateWeightInGold
            // 
            this.cmdCalculateWeightInGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalculateWeightInGold.Location = new System.Drawing.Point(302, 245);
            this.cmdCalculateWeightInGold.Name = "cmdCalculateWeightInGold";
            this.cmdCalculateWeightInGold.Size = new System.Drawing.Size(177, 42);
            this.cmdCalculateWeightInGold.TabIndex = 9;
            this.cmdCalculateWeightInGold.Text = "&Calculate";
            this.cmdCalculateWeightInGold.UseVisualStyleBackColor = true;
            this.cmdCalculateWeightInGold.Click += new System.EventHandler(this.cmdCalculateWeightInGold_Click);
            // 
            // txtGoldPrice
            // 
            this.txtGoldPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoldPrice.Location = new System.Drawing.Point(302, 94);
            this.txtGoldPrice.Name = "txtGoldPrice";
            this.txtGoldPrice.Size = new System.Drawing.Size(158, 30);
            this.txtGoldPrice.TabIndex = 6;
            // 
            // txtUserWeight
            // 
            this.txtUserWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserWeight.Location = new System.Drawing.Point(302, 22);
            this.txtUserWeight.Name = "txtUserWeight";
            this.txtUserWeight.Size = new System.Drawing.Size(158, 30);
            this.txtUserWeight.TabIndex = 4;
            // 
            // lblPriceOfGold
            // 
            this.lblPriceOfGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceOfGold.Location = new System.Drawing.Point(22, 74);
            this.lblPriceOfGold.Name = "lblPriceOfGold";
            this.lblPriceOfGold.Size = new System.Drawing.Size(273, 50);
            this.lblPriceOfGold.TabIndex = 7;
            this.lblPriceOfGold.Text = "Enter the current price of gold per troy ounce in U.S. Dollars:";
            // 
            // lblEnterWeight
            // 
            this.lblEnterWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterWeight.Location = new System.Drawing.Point(22, 22);
            this.lblEnterWeight.Name = "lblEnterWeight";
            this.lblEnterWeight.Size = new System.Drawing.Size(273, 25);
            this.lblEnterWeight.TabIndex = 5;
            this.lblEnterWeight.Text = "Enter your weight (in pounds):";
            // 
            // imgGoldBars
            // 
            this.imgGoldBars.BackColor = System.Drawing.Color.Transparent;
            this.imgGoldBars.Image = global::WeightInGold.Properties.Resources.GoldBars;
            this.imgGoldBars.Location = new System.Drawing.Point(27, 143);
            this.imgGoldBars.Name = "imgGoldBars";
            this.imgGoldBars.Size = new System.Drawing.Size(193, 157);
            this.imgGoldBars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgGoldBars.TabIndex = 10;
            this.imgGoldBars.TabStop = false;
            // 
            // frmWeightInGold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 312);
            this.Controls.Add(this.imgGoldBars);
            this.Controls.Add(this.linkLblGoldPriceOrg);
            this.Controls.Add(this.cmdCalculateWeightInGold);
            this.Controls.Add(this.txtGoldPrice);
            this.Controls.Add(this.txtUserWeight);
            this.Controls.Add(this.lblPriceOfGold);
            this.Controls.Add(this.lblEnterWeight);
            this.Name = "frmWeightInGold";
            this.Text = "Your Weight in Gold";
            this.Load += new System.EventHandler(this.frmWeightInGold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgGoldBars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLblGoldPriceOrg;
        private System.Windows.Forms.Button cmdCalculateWeightInGold;
        private System.Windows.Forms.TextBox txtGoldPrice;
        private System.Windows.Forms.TextBox txtUserWeight;
        private System.Windows.Forms.Label lblPriceOfGold;
        private System.Windows.Forms.Label lblEnterWeight;
        private System.Windows.Forms.PictureBox imgGoldBars;
    }
}

