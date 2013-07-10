namespace Homework1
{
    partial class AlexHomework1SuperDuperExtraCreditForm
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
            this.superDuperExtraCreditLabel = new System.Windows.Forms.Label();
            this.blackArtLabel = new System.Windows.Forms.Label();
            this.textSpellInput = new System.Windows.Forms.TextBox();
            this.magicButton = new System.Windows.Forms.Button();
            this.spellInputLabel = new System.Windows.Forms.Label();
            this.spellServiceLabel = new System.Windows.Forms.Label();
            this.blackArtServiceLabel = new System.Windows.Forms.Label();
            this.spellResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // superDuperExtraCreditLabel
            // 
            this.superDuperExtraCreditLabel.AutoSize = true;
            this.superDuperExtraCreditLabel.Location = new System.Drawing.Point(129, 26);
            this.superDuperExtraCreditLabel.Name = "superDuperExtraCreditLabel";
            this.superDuperExtraCreditLabel.Size = new System.Drawing.Size(186, 13);
            this.superDuperExtraCreditLabel.TabIndex = 0;
            this.superDuperExtraCreditLabel.Text = "Super Duper Extra Credit functionality.";
            // 
            // blackArtLabel
            // 
            this.blackArtLabel.AutoSize = true;
            this.blackArtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackArtLabel.Location = new System.Drawing.Point(129, 140);
            this.blackArtLabel.Name = "blackArtLabel";
            this.blackArtLabel.Size = new System.Drawing.Size(233, 13);
            this.blackArtLabel.TabIndex = 1;
            this.blackArtLabel.Text = "WHOA! Black Art Of Computer Science!";
            this.blackArtLabel.Visible = false;
            // 
            // textSpellInput
            // 
            this.textSpellInput.Location = new System.Drawing.Point(132, 73);
            this.textSpellInput.Name = "textSpellInput";
            this.textSpellInput.Size = new System.Drawing.Size(183, 20);
            this.textSpellInput.TabIndex = 2;
            this.textSpellInput.TextChanged += new System.EventHandler(this.textSpellInput_TextChanged);
            this.textSpellInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textSpellInput_KeyUp);
            // 
            // magicButton
            // 
            this.magicButton.Location = new System.Drawing.Point(132, 236);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(179, 23);
            this.magicButton.TabIndex = 3;
            this.magicButton.Text = "Magic Button";
            this.magicButton.UseVisualStyleBackColor = true;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click);
            // 
            // spellInputLabel
            // 
            this.spellInputLabel.AutoSize = true;
            this.spellInputLabel.Location = new System.Drawing.Point(129, 57);
            this.spellInputLabel.Name = "spellInputLabel";
            this.spellInputLabel.Size = new System.Drawing.Size(218, 13);
            this.spellInputLabel.TabIndex = 4;
            this.spellInputLabel.Text = "Enter your spell (50 characters limit per spell):";
            // 
            // spellServiceLabel
            // 
            this.spellServiceLabel.AutoSize = true;
            this.spellServiceLabel.Location = new System.Drawing.Point(132, 100);
            this.spellServiceLabel.Name = "spellServiceLabel";
            this.spellServiceLabel.Size = new System.Drawing.Size(179, 13);
            this.spellServiceLabel.TabIndex = 5;
            this.spellServiceLabel.Text = "and click [Magic Button] once done.";
            this.spellServiceLabel.Visible = false;
            // 
            // blackArtServiceLabel
            // 
            this.blackArtServiceLabel.AutoSize = true;
            this.blackArtServiceLabel.Location = new System.Drawing.Point(132, 157);
            this.blackArtServiceLabel.Name = "blackArtServiceLabel";
            this.blackArtServiceLabel.Size = new System.Drawing.Size(66, 13);
            this.blackArtServiceLabel.TabIndex = 6;
            this.blackArtServiceLabel.Text = "Your spell is:";
            this.blackArtServiceLabel.Visible = false;
            // 
            // spellResultLabel
            // 
            this.spellResultLabel.AutoSize = true;
            this.spellResultLabel.Location = new System.Drawing.Point(205, 157);
            this.spellResultLabel.Name = "spellResultLabel";
            this.spellResultLabel.Size = new System.Drawing.Size(0, 13);
            this.spellResultLabel.TabIndex = 7;
            // 
            // AlexHomework1SuperDuperExtraCreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 300);
            this.Controls.Add(this.spellResultLabel);
            this.Controls.Add(this.blackArtServiceLabel);
            this.Controls.Add(this.spellServiceLabel);
            this.Controls.Add(this.spellInputLabel);
            this.Controls.Add(this.magicButton);
            this.Controls.Add(this.textSpellInput);
            this.Controls.Add(this.blackArtLabel);
            this.Controls.Add(this.superDuperExtraCreditLabel);
            this.Name = "AlexHomework1SuperDuperExtraCreditForm";
            this.Text = "Alex P Homework 1 Super Duper Extra Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label superDuperExtraCreditLabel;
        private System.Windows.Forms.Label blackArtLabel;
        private System.Windows.Forms.TextBox textSpellInput;
        private System.Windows.Forms.Button magicButton;
        private System.Windows.Forms.Label spellInputLabel;
        private System.Windows.Forms.Label spellServiceLabel;
        private System.Windows.Forms.Label blackArtServiceLabel;
        private System.Windows.Forms.Label spellResultLabel;
    }
}