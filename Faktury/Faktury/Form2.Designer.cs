
namespace Faktury
{
    partial class Form2
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.ZamknijButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.KontrahentTextBox = new System.Windows.Forms.TextBox();
            this.NumerFakturyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NazwaTowaruTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IloscSztukTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CenaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(104, 348);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(208, 39);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Akceptuj";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // ZamknijButton
            // 
            this.ZamknijButton.Location = new System.Drawing.Point(104, 394);
            this.ZamknijButton.Name = "ZamknijButton";
            this.ZamknijButton.Size = new System.Drawing.Size(208, 41);
            this.ZamknijButton.TabIndex = 1;
            this.ZamknijButton.Text = "Anuluj";
            this.ZamknijButton.UseVisualStyleBackColor = true;
            this.ZamknijButton.Click += new System.EventHandler(this.ZamknijButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NazwaKontrahent ";
            // 
            // KontrahentTextBox
            // 
            this.KontrahentTextBox.Location = new System.Drawing.Point(153, 42);
            this.KontrahentTextBox.Name = "KontrahentTextBox";
            this.KontrahentTextBox.Size = new System.Drawing.Size(100, 20);
            this.KontrahentTextBox.TabIndex = 3;
            // 
            // NumerFakturyTextBox
            // 
            this.NumerFakturyTextBox.Location = new System.Drawing.Point(153, 81);
            this.NumerFakturyTextBox.Name = "NumerFakturyTextBox";
            this.NumerFakturyTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumerFakturyTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NumerFaktury";
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(153, 111);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(100, 20);
            this.DataTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data";
            // 
            // NazwaTowaruTextBox
            // 
            this.NazwaTowaruTextBox.Location = new System.Drawing.Point(153, 145);
            this.NazwaTowaruTextBox.Name = "NazwaTowaruTextBox";
            this.NazwaTowaruTextBox.Size = new System.Drawing.Size(100, 20);
            this.NazwaTowaruTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "NazwaTowaru";
            // 
            // IloscSztukTextBox
            // 
            this.IloscSztukTextBox.Location = new System.Drawing.Point(153, 173);
            this.IloscSztukTextBox.Name = "IloscSztukTextBox";
            this.IloscSztukTextBox.Size = new System.Drawing.Size(100, 20);
            this.IloscSztukTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "IlośćSztuk";
            // 
            // CenaTextBox
            // 
            this.CenaTextBox.Location = new System.Drawing.Point(153, 210);
            this.CenaTextBox.Name = "CenaTextBox";
            this.CenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.CenaTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cena";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 465);
            this.Controls.Add(this.CenaTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IloscSztukTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NazwaTowaruTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumerFakturyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KontrahentTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZamknijButton);
            this.Controls.Add(this.AcceptButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button ZamknijButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KontrahentTextBox;
        private System.Windows.Forms.TextBox NumerFakturyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NazwaTowaruTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IloscSztukTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CenaTextBox;
        private System.Windows.Forms.Label label6;
    }
}