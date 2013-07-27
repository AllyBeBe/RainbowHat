namespace TicketPriceCalculator
{
	partial class Calc
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
			this.BtnAdult = new System.Windows.Forms.Button();
			this.BtnChild = new System.Windows.Forms.Button();
			this.BtnSenior = new System.Windows.Forms.Button();
			this.TxtSelection = new System.Windows.Forms.TextBox();
			this.LblGroupDiscount = new System.Windows.Forms.Label();
			this.BtnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtnAdult
			// 
			this.BtnAdult.Location = new System.Drawing.Point(44, 88);
			this.BtnAdult.Name = "BtnAdult";
			this.BtnAdult.Size = new System.Drawing.Size(89, 69);
			this.BtnAdult.TabIndex = 0;
			this.BtnAdult.Text = "Adult Ticket";
			this.BtnAdult.UseVisualStyleBackColor = true;
			this.BtnAdult.Click += new System.EventHandler(this.BtnAdult_Click);
			// 
			// BtnChild
			// 
			this.BtnChild.Location = new System.Drawing.Point(139, 88);
			this.BtnChild.Name = "BtnChild";
			this.BtnChild.Size = new System.Drawing.Size(89, 69);
			this.BtnChild.TabIndex = 1;
			this.BtnChild.Text = "Child Ticket";
			this.BtnChild.UseVisualStyleBackColor = true;
			this.BtnChild.Click += new System.EventHandler(this.BtnChild_Click);
			// 
			// BtnSenior
			// 
			this.BtnSenior.Location = new System.Drawing.Point(44, 163);
			this.BtnSenior.Name = "BtnSenior";
			this.BtnSenior.Size = new System.Drawing.Size(89, 69);
			this.BtnSenior.TabIndex = 2;
			this.BtnSenior.Text = "Senior Ticket";
			this.BtnSenior.UseVisualStyleBackColor = true;
			this.BtnSenior.Click += new System.EventHandler(this.BtnSenior_Click);
			// 
			// TxtSelection
			// 
			this.TxtSelection.Location = new System.Drawing.Point(44, 21);
			this.TxtSelection.Name = "TxtSelection";
			this.TxtSelection.ReadOnly = true;
			this.TxtSelection.Size = new System.Drawing.Size(199, 20);
			this.TxtSelection.TabIndex = 4;
			// 
			// LblGroupDiscount
			// 
			this.LblGroupDiscount.AutoSize = true;
			this.LblGroupDiscount.Location = new System.Drawing.Point(41, 59);
			this.LblGroupDiscount.Name = "LblGroupDiscount";
			this.LblGroupDiscount.Size = new System.Drawing.Size(0, 13);
			this.LblGroupDiscount.TabIndex = 5;
			// 
			// BtnClear
			// 
			this.BtnClear.Location = new System.Drawing.Point(139, 163);
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.Size = new System.Drawing.Size(89, 69);
			this.BtnClear.TabIndex = 6;
			this.BtnClear.Text = "Clear";
			this.BtnClear.UseVisualStyleBackColor = true;
			this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// Calc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 266);
			this.Controls.Add(this.BtnClear);
			this.Controls.Add(this.LblGroupDiscount);
			this.Controls.Add(this.TxtSelection);
			this.Controls.Add(this.BtnSenior);
			this.Controls.Add(this.BtnChild);
			this.Controls.Add(this.BtnAdult);
			this.Name = "Calc";
			this.Text = "Movie Ticket Price Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnAdult;
		private System.Windows.Forms.Button BtnChild;
		private System.Windows.Forms.Button BtnSenior;
		private System.Windows.Forms.TextBox TxtSelection;
		private System.Windows.Forms.Label LblGroupDiscount;
		private System.Windows.Forms.Button BtnClear;

		
	}
}

