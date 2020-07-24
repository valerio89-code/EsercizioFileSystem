namespace EsercizioFileSystem
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
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.tbx_comune = new System.Windows.Forms.TextBox();
            this.tbx_cognome = new System.Windows.Forms.TextBox();
            this.dpk_nascita = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_mostraCSV = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_salvaDati = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_apriCSV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.aggiungiPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDiNascitaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comuneDiNascitaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(140, 7);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(243, 26);
            this.tbx_nome.TabIndex = 0;
            // 
            // tbx_comune
            // 
            this.tbx_comune.Location = new System.Drawing.Point(140, 154);
            this.tbx_comune.Name = "tbx_comune";
            this.tbx_comune.Size = new System.Drawing.Size(243, 26);
            this.tbx_comune.TabIndex = 4;
            // 
            // tbx_cognome
            // 
            this.tbx_cognome.Location = new System.Drawing.Point(140, 56);
            this.tbx_cognome.Name = "tbx_cognome";
            this.tbx_cognome.Size = new System.Drawing.Size(243, 26);
            this.tbx_cognome.TabIndex = 3;
            // 
            // dpk_nascita
            // 
            this.dpk_nascita.Location = new System.Drawing.Point(140, 105);
            this.dpk_nascita.Name = "dpk_nascita";
            this.dpk_nascita.Size = new System.Drawing.Size(243, 26);
            this.dpk_nascita.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Comune";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data nascita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cognome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 66);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aggiungi a CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mostraCSV
            // 
            this.btn_mostraCSV.Location = new System.Drawing.Point(30, 325);
            this.btn_mostraCSV.Name = "btn_mostraCSV";
            this.btn_mostraCSV.Size = new System.Drawing.Size(121, 66);
            this.btn_mostraCSV.TabIndex = 12;
            this.btn_mostraCSV.Text = "Mostra CSV";
            this.btn_mostraCSV.UseVisualStyleBackColor = true;
            this.btn_mostraCSV.Click += new System.EventHandler(this.btn_mostraCSV_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn1,
            this.cognomeDataGridViewTextBoxColumn1,
            this.dataDiNascitaDataGridViewTextBoxColumn1,
            this.comuneDiNascitaDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.personaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(424, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1073, 546);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView2_CellValidating);
            this.dataGridView2.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView2_RowValidating);
            // 
            // btn_salvaDati
            // 
            this.btn_salvaDati.Location = new System.Drawing.Point(281, 253);
            this.btn_salvaDati.Name = "btn_salvaDati";
            this.btn_salvaDati.Size = new System.Drawing.Size(121, 66);
            this.btn_salvaDati.TabIndex = 14;
            this.btn_salvaDati.Text = "Salva dati tabella in csv";
            this.btn_salvaDati.UseVisualStyleBackColor = true;
            this.btn_salvaDati.Click += new System.EventHandler(this.btn_salvaDati_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_apriCSV,
            this.toolStripSplitButton1,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1509, 33);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_apriCSV
            // 
            this.tsbtn_apriCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_apriCSV.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_apriCSV.Image")));
            this.tsbtn_apriCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_apriCSV.Name = "tsbtn_apriCSV";
            this.tsbtn_apriCSV.Size = new System.Drawing.Size(34, 28);
            this.tsbtn_apriCSV.Text = "toolStripButton1";
            this.tsbtn_apriCSV.Click += new System.EventHandler(this.tsbtn_apriCSV_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiPersonaToolStripMenuItem,
            this.stampaToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(45, 28);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // aggiungiPersonaToolStripMenuItem
            // 
            this.aggiungiPersonaToolStripMenuItem.Name = "aggiungiPersonaToolStripMenuItem";
            this.aggiungiPersonaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aggiungiPersonaToolStripMenuItem.Text = "Aggiungi persona";
            this.aggiungiPersonaToolStripMenuItem.Click += new System.EventHandler(this.aggiungiPersonaToolStripMenuItem_Click);
            // 
            // stampaToolStripMenuItem
            // 
            this.stampaToolStripMenuItem.Name = "stampaToolStripMenuItem";
            this.stampaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.stampaToolStripMenuItem.Text = "Stampa";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.csv)|*.csv";
            this.openFileDialog1.InitialDirectory = "C:\\Corso c#";
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // cognomeDataGridViewTextBoxColumn1
            // 
            this.cognomeDataGridViewTextBoxColumn1.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn1.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.cognomeDataGridViewTextBoxColumn1.Name = "cognomeDataGridViewTextBoxColumn1";
            this.cognomeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataDiNascitaDataGridViewTextBoxColumn1
            // 
            this.dataDiNascitaDataGridViewTextBoxColumn1.DataPropertyName = "DataDiNascita";
            this.dataDiNascitaDataGridViewTextBoxColumn1.HeaderText = "DataDiNascita";
            this.dataDiNascitaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataDiNascitaDataGridViewTextBoxColumn1.Name = "dataDiNascitaDataGridViewTextBoxColumn1";
            this.dataDiNascitaDataGridViewTextBoxColumn1.Width = 150;
            // 
            // comuneDiNascitaDataGridViewTextBoxColumn1
            // 
            this.comuneDiNascitaDataGridViewTextBoxColumn1.DataPropertyName = "ComuneDiNascita";
            this.comuneDiNascitaDataGridViewTextBoxColumn1.HeaderText = "ComuneDiNascita";
            this.comuneDiNascitaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.comuneDiNascitaDataGridViewTextBoxColumn1.Name = "comuneDiNascitaDataGridViewTextBoxColumn1";
            this.comuneDiNascitaDataGridViewTextBoxColumn1.Width = 150;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(EsercizioFileSystem.Code.Persona);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dpk_nascita);
            this.panel1.Controls.Add(this.tbx_cognome);
            this.panel1.Controls.Add(this.tbx_comune);
            this.panel1.Controls.Add(this.tbx_nome);
            this.panel1.Location = new System.Drawing.Point(19, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 198);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_salvaDati);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_mostraCSV);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.TextBox tbx_comune;
        private System.Windows.Forms.TextBox tbx_cognome;
        private System.Windows.Forms.DateTimePicker dpk_nascita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_mostraCSV;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDiNascitaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn comuneDiNascitaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btn_salvaDati;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_apriCSV;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem aggiungiPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stampaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}

