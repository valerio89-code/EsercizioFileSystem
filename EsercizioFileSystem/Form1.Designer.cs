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
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.tbx_comune = new System.Windows.Forms.TextBox();
            this.tbx_cognome = new System.Windows.Forms.TextBox();
            this.dpk_nascita = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_mostraCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(159, 53);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(243, 26);
            this.tbx_nome.TabIndex = 0;
            // 
            // tbx_comune
            // 
            this.tbx_comune.Location = new System.Drawing.Point(159, 200);
            this.tbx_comune.Name = "tbx_comune";
            this.tbx_comune.Size = new System.Drawing.Size(243, 26);
            this.tbx_comune.TabIndex = 3;
            // 
            // tbx_cognome
            // 
            this.tbx_cognome.Location = new System.Drawing.Point(159, 102);
            this.tbx_cognome.Name = "tbx_cognome";
            this.tbx_cognome.Size = new System.Drawing.Size(243, 26);
            this.tbx_cognome.TabIndex = 4;
            // 
            // dpk_nascita
            // 
            this.dpk_nascita.Location = new System.Drawing.Point(159, 151);
            this.dpk_nascita.Name = "dpk_nascita";
            this.dpk_nascita.Size = new System.Drawing.Size(243, 26);
            this.dpk_nascita.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Comune";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data nascita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cognome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 123);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aggiungi a CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(567, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(740, 362);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_mostraCSV
            // 
            this.btn_mostraCSV.Location = new System.Drawing.Point(260, 290);
            this.btn_mostraCSV.Name = "btn_mostraCSV";
            this.btn_mostraCSV.Size = new System.Drawing.Size(187, 123);
            this.btn_mostraCSV.TabIndex = 12;
            this.btn_mostraCSV.Text = "Mostra CSV";
            this.btn_mostraCSV.UseVisualStyleBackColor = true;
            this.btn_mostraCSV.Click += new System.EventHandler(this.btn_mostraCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 450);
            this.Controls.Add(this.btn_mostraCSV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpk_nascita);
            this.Controls.Add(this.tbx_cognome);
            this.Controls.Add(this.tbx_comune);
            this.Controls.Add(this.tbx_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_mostraCSV;
    }
}

