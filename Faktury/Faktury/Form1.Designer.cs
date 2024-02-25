
namespace Faktury
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numerFakturyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontrahentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaFakturBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DodajFakture = new System.Windows.Forms.Button();
            this.ZamknijButton = new System.Windows.Forms.Button();
            this.EdytujButton = new System.Windows.Forms.Button();
            this.fakturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFakturBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerFakturyDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.kontrahentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listaFakturBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numerFakturyDataGridViewTextBoxColumn
            // 
            this.numerFakturyDataGridViewTextBoxColumn.DataPropertyName = "NumerFaktury";
            this.numerFakturyDataGridViewTextBoxColumn.HeaderText = "NumerFaktury";
            this.numerFakturyDataGridViewTextBoxColumn.Name = "numerFakturyDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // kontrahentDataGridViewTextBoxColumn
            // 
            this.kontrahentDataGridViewTextBoxColumn.DataPropertyName = "Kontrahent";
            this.kontrahentDataGridViewTextBoxColumn.HeaderText = "Kontrahent";
            this.kontrahentDataGridViewTextBoxColumn.Name = "kontrahentDataGridViewTextBoxColumn";
            // 
            // listaFakturBindingSource
            // 
            this.listaFakturBindingSource.DataSource = typeof(Faktury.ListaFaktur);
            // 
            // DodajFakture
            // 
            this.DodajFakture.Location = new System.Drawing.Point(397, 24);
            this.DodajFakture.Name = "DodajFakture";
            this.DodajFakture.Size = new System.Drawing.Size(145, 23);
            this.DodajFakture.TabIndex = 1;
            this.DodajFakture.Text = "Dodaj";
            this.DodajFakture.UseVisualStyleBackColor = true;
            this.DodajFakture.Click += new System.EventHandler(this.DodajFakture_Click);
            // 
            // ZamknijButton
            // 
            this.ZamknijButton.Location = new System.Drawing.Point(397, 96);
            this.ZamknijButton.Name = "ZamknijButton";
            this.ZamknijButton.Size = new System.Drawing.Size(145, 26);
            this.ZamknijButton.TabIndex = 4;
            this.ZamknijButton.Text = "Zamknij";
            this.ZamknijButton.UseVisualStyleBackColor = true;
            this.ZamknijButton.Click += new System.EventHandler(this.ZamknijButton_Click);
            // 
            // EdytujButton
            // 
            this.EdytujButton.Location = new System.Drawing.Point(397, 53);
            this.EdytujButton.Name = "EdytujButton";
            this.EdytujButton.Size = new System.Drawing.Size(145, 23);
            this.EdytujButton.TabIndex = 5;
            this.EdytujButton.Text = "Edytuj";
            this.EdytujButton.UseVisualStyleBackColor = true;
            this.EdytujButton.Click += new System.EventHandler(this.EdytujButton_Click);
            // 
            // fakturaBindingSource
            // 
            this.fakturaBindingSource.DataSource = typeof(Faktury.Faktura);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.Location = new System.Drawing.Point(397, 138);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(145, 26);
            this.DeleteRecord.TabIndex = 6;
            this.DeleteRecord.Text = "UsuńRekord";
            this.DeleteRecord.UseVisualStyleBackColor = true;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 368);
            this.Controls.Add(this.DeleteRecord);
            this.Controls.Add(this.EdytujButton);
            this.Controls.Add(this.ZamknijButton);
            this.Controls.Add(this.DodajFakture);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFakturBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fakturaBindingSource;
        private System.Windows.Forms.Button DodajFakture;
        private System.Windows.Forms.Button ZamknijButton;
        private System.Windows.Forms.BindingSource listaFakturBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerFakturyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrahentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button EdytujButton;
        private System.Windows.Forms.Button DeleteRecord;
    }
}

