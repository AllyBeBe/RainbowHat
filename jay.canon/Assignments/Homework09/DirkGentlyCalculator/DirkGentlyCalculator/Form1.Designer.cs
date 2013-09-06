using System.Windows.Forms;

namespace Calculator
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
        protected void buttonEquals_OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Enter pressed", "Attention");
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonTimes = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonInverse = new System.Windows.Forms.Button();
            this.buttonXSquared = new System.Windows.Forms.Button();
            this.buttonSIN = new System.Windows.Forms.Button();
            this.buttonCOS = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 421);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.Tag = "1";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 421);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 2;
            this.button2.Tag = "2";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 421);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 367);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 4;
            this.button4.Tag = "4";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(83, 367);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 5;
            this.button5.Tag = "5";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(139, 367);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 6;
            this.button6.Tag = "6";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 313);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 7;
            this.button7.Tag = "7";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(83, 313);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 8;
            this.button8.Tag = "8";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(139, 313);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 9;
            this.button9.Tag = "9";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(83, 475);
            this.button0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 50);
            this.button0.TabIndex = 10;
            this.button0.Tag = "0";
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(195, 475);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(50, 50);
            this.buttonPlus.TabIndex = 11;
            this.buttonPlus.Tag = "+";
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this._buttonHolder_Click);
            this.buttonPlus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(195, 421);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(50, 50);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Tag = "-";
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this._buttonHolder_Click);
            this.buttonMinus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // buttonTimes
            // 
            this.buttonTimes.Location = new System.Drawing.Point(195, 367);
            this.buttonTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTimes.Name = "buttonTimes";
            this.buttonTimes.Size = new System.Drawing.Size(50, 50);
            this.buttonTimes.TabIndex = 13;
            this.buttonTimes.Tag = "*";
            this.buttonTimes.Text = "*";
            this.buttonTimes.UseVisualStyleBackColor = true;
            this.buttonTimes.Click += new System.EventHandler(this._buttonHolder_Click);
            this.buttonTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(195, 313);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(50, 50);
            this.buttonDivide.TabIndex = 14;
            this.buttonDivide.Tag = "/";
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this._buttonHolder_Click);
            this.buttonDivide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(251, 475);
            this.buttonEquals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(50, 50);
            this.buttonEquals.TabIndex = 15;
            this.buttonEquals.Tag = "=";
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this._buttonHolder_Click);
            this.buttonEquals.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonEquals_OnKeyPress);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClear.Location = new System.Drawing.Point(195, 259);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 50);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Tag = "c";
            this.buttonClear.Text = "c";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this._buttonHolder_Click);
            this.buttonClear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(27, 475);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(50, 50);
            this.buttonSign.TabIndex = 18;
            this.buttonSign.Tag = "x";
            this.buttonSign.Text = "+/-";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this._buttonHolder_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Location = new System.Drawing.Point(139, 475);
            this.buttonDecimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(50, 50);
            this.buttonDecimal.TabIndex = 19;
            this.buttonDecimal.Tag = ".";
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this._buttonHolder_Click);
            this.buttonDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Location = new System.Drawing.Point(251, 367);
            this.buttonPercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(50, 50);
            this.buttonPercent.TabIndex = 20;
            this.buttonPercent.Tag = "%";
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Transparent;
            this.buttonRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRed.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRed.Image = ((System.Drawing.Image)(resources.GetObject("buttonRed.Image")));
            this.buttonRed.Location = new System.Drawing.Point(27, 259);
            this.buttonRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(67, 30);
            this.buttonRed.TabIndex = 21;
            this.buttonRed.Tag = "r";
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonInverse
            // 
            this.buttonInverse.Location = new System.Drawing.Point(319, 313);
            this.buttonInverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInverse.Name = "buttonInverse";
            this.buttonInverse.Size = new System.Drawing.Size(50, 50);
            this.buttonInverse.TabIndex = 22;
            this.buttonInverse.Tag = "i";
            this.buttonInverse.Text = "1/x";
            this.buttonInverse.UseVisualStyleBackColor = true;
            this.buttonInverse.Click += new System.EventHandler(this._buttonHolder_Click);
            // 
            // buttonXSquared
            // 
            this.buttonXSquared.Location = new System.Drawing.Point(375, 313);
            this.buttonXSquared.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXSquared.Name = "buttonXSquared";
            this.buttonXSquared.Size = new System.Drawing.Size(50, 50);
            this.buttonXSquared.TabIndex = 23;
            this.buttonXSquared.Tag = "q";
            this.buttonXSquared.Text = "x2";
            this.buttonXSquared.UseVisualStyleBackColor = true;
            this.buttonXSquared.Click += new System.EventHandler(this._buttonHolder_Click);
            // 
            // buttonSIN
            // 
            this.buttonSIN.Location = new System.Drawing.Point(319, 367);
            this.buttonSIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSIN.Name = "buttonSIN";
            this.buttonSIN.Size = new System.Drawing.Size(106, 50);
            this.buttonSIN.TabIndex = 24;
            this.buttonSIN.Tag = "s";
            this.buttonSIN.Text = "SIN";
            this.buttonSIN.UseVisualStyleBackColor = true;
            this.buttonSIN.Click += new System.EventHandler(this._buttonHolder_Click);
            // 
            // buttonCOS
            // 
            this.buttonCOS.Location = new System.Drawing.Point(319, 421);
            this.buttonCOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCOS.Name = "buttonCOS";
            this.buttonCOS.Size = new System.Drawing.Size(106, 50);
            this.buttonCOS.TabIndex = 25;
            this.buttonCOS.Tag = "o";
            this.buttonCOS.Text = "COS";
            this.buttonCOS.UseVisualStyleBackColor = true;
            this.buttonCOS.Click += new System.EventHandler(this._buttonHolder_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(319, 475);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(106, 50);
            this.button10.TabIndex = 26;
            this.button10.Tag = "t";
            this.button10.Text = "TAN";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this._buttonHolder_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(14, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(411, 231);
            this.webBrowser1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 545);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonCOS);
            this.Controls.Add(this.buttonSIN);
            this.Controls.Add(this.buttonXSquared);
            this.Controls.Add(this.buttonInverse);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonTimes);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "I-Ching Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonTimes;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonClear;
        private Button buttonSign;
        private Button buttonDecimal;
        private Button buttonPercent;
        private Button buttonRed;
        private Button buttonInverse;
        private Button buttonXSquared;
        private Button buttonSIN;
        private Button buttonCOS;
        private Button button10;
        private WebBrowser webBrowser1;
        
    }
}

