
namespace Faktury
{
    partial class Form4
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
            this.NumerFakturyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.ZamknijButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumerFakturyTextBox
            // 
            this.NumerFakturyTextBox.Location = new System.Drawing.Point(141, 23);
            this.NumerFakturyTextBox.Name = "NumerFakturyTextBox";
            this.NumerFakturyTextBox.Size = new System.Drawing.Size(79, 20);
            this.NumerFakturyTextBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "NumerFakturydoUsunięcia";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(15, 61);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(120, 35);
            this.AcceptButton.TabIndex = 28;
            this.AcceptButton.Text = "Akceptuj";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // ZamknijButton
            // 
            this.ZamknijButton.Location = new System.Drawing.Point(141, 61);
            this.ZamknijButton.Name = "ZamknijButton";
            this.ZamknijButton.Size = new System.Drawing.Size(79, 35);
            this.ZamknijButton.TabIndex = 27;
            this.ZamknijButton.Text = "Anuluj";
            this.ZamknijButton.UseVisualStyleBackColor = true;
            this.ZamknijButton.Click += new System.EventHandler(this.ZamknijButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 122);
            this.Controls.Add(this.NumerFakturyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ZamknijButton);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumerFakturyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button ZamknijButton;
    }
}