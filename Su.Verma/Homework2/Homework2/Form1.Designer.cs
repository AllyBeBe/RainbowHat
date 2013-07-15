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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.toolTipFirstName = new System.Windows.Forms.PictureBox();
            this.toolTipLastName = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toolTipFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTipLastName)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(184, 33);
            this.firstNameTextBox.Multiline = true;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(129, 30);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(30, 35);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(76, 17);
            this.firstName.TabIndex = 2;
            this.firstName.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(30, 82);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(76, 17);
            this.lastName.TabIndex = 40;
            this.lastName.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(184, 70);
            this.lastNameTextBox.Multiline = true;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(129, 30);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // toolTipFirstName
            // 
            this.toolTipFirstName.ErrorImage = ((System.Drawing.Image)(resources.GetObject("toolTipFirstName.ErrorImage")));
            this.toolTipFirstName.Image = ((System.Drawing.Image)(resources.GetObject("toolTipFirstName.Image")));
            this.toolTipFirstName.Location = new System.Drawing.Point(125, 35);
            this.toolTipFirstName.Name = "toolTipFirstName";
            this.toolTipFirstName.Size = new System.Drawing.Size(26, 28);
            this.toolTipFirstName.TabIndex = 5;
            this.toolTipFirstName.TabStop = false;
            this.toolTip1.SetToolTip(this.toolTipFirstName, "Enter First Name");
            // 
            // toolTipLastName
            // 
            this.toolTipLastName.ErrorImage = ((System.Drawing.Image)(resources.GetObject("toolTipLastName.ErrorImage")));
            this.toolTipLastName.Image = ((System.Drawing.Image)(resources.GetObject("toolTipLastName.Image")));
            this.toolTipLastName.Location = new System.Drawing.Point(125, 72);
            this.toolTipLastName.Name = "toolTipLastName";
            this.toolTipLastName.Size = new System.Drawing.Size(26, 28);
            this.toolTipLastName.TabIndex = 41;
            this.toolTipLastName.TabStop = false;
            this.toolTip2.SetToolTip(this.toolTipLastName, "Enter Last Name");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 262);
            this.Controls.Add(this.toolTipLastName);
            this.Controls.Add(this.toolTipFirstName);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.toolTipFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTipLastName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.PictureBox toolTipFirstName;
        private System.Windows.Forms.PictureBox toolTipLastName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

