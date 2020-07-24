using EsercizioFileSystem.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsercizioFileSystem
{
    public partial class Form1 : Form
    {
        string filePath { get; set; }
        public Form1()
        {
            InitializeComponent();
            //aggiungo manualmente un handler all'evento click
            button1.Click += new EventHandler((sender, e) =>
            {
                MessageBox.Show("click su button1");
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = tbx_nome.Text;
            var cognome = tbx_cognome.Text;
            var dataNascita = dpk_nascita.Value;
            var comune = tbx_comune.Text;
            using (var streamWriter = new StreamWriter(filePath, true))
            {
                ScriviRigaSuCSV(streamWriter, nome, cognome, dataNascita, comune);
            }
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
            MessageBox.Show("Salvataggio eseguito con successo", "COMPLIMENTI");
        }

        private void btn_mostraCSV_Click(object sender, EventArgs e)
        {
            AssociaDataSource();
        }
        private void AssociaDataSource()
        {
            dataGridView2.DataSource = GetDataFromCSV();
        }
        private BindingList<Persona> GetDataFromCSV()
        {
            var list = new BindingList<Persona>();
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                while (true)
                {
                    var line = streamReader.ReadLine();
                    if (line == null) break;
                    if (line == string.Empty) continue;
                    //gianni,mina,31/10/2024,iglesias
                    //[gianni, mina, 31/10/20124, iglesias]
                    string[] splittedLine = line.Split(',');
                    list.Add(new Persona
                    {
                        Nome = splittedLine[0],
                        Cognome = splittedLine[1],
                        DataDiNascita = DateTime.Parse(splittedLine[2]),
                        ComuneDiNascita = splittedLine[3]
                    });
                }
            }
            return list;
        }

        private void btn_salvaDati_Click(object sender, EventArgs e)
        {
            using (var streamWriter = new StreamWriter(filePath))
            {
                var dt = new DataTable();
                var lista = dataGridView2.DataSource as BindingSource;
                foreach (var item in lista.Cast<Persona>())
                {
                    ScriviRigaSuCSV(streamWriter, item.Nome, item.Cognome, item.DataDiNascita, item.ComuneDiNascita);
                }
            }
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //valido la colonna ComuneDiNascita e scrivo un messaggio di errore nella riga
            var valoriComuneDiNascita = new List<string> { "Carbonia", "Iglesias", "Cagliari" };
            if (dataGridView2.Columns[e.ColumnIndex].HeaderText == "ComuneDiNascita")
            {
                var value = e.FormattedValue;
                if (!valoriComuneDiNascita.Contains(value))
                {
                    dataGridView2.Rows[e.RowIndex].ErrorText = "Comune non valido";
                }
            }
        }

        //esempio di dependency injection
        private void ScriviRigaSuCSV(StreamWriter streamWriter, string nome, string cognome, DateTime dataNascita, string comune)
        {
            streamWriter.WriteLine($"{nome},{cognome},{dataNascita.ToShortDateString()},{comune}");
            streamWriter.Flush();
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //se è stato sollevato l'evento CellEndEdit, significa che la validazione è andata a buon fine 
            //e quindi posso svuotare l'errore della riga
            dataGridView2.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void dataGridView2_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //valido la riga e inserisco l'errore nella cella cognome se lasciata vuota
            var row = dataGridView2.Rows[e.RowIndex];
            var cellaCognome = row.Cells[1];
            if (cellaCognome.Value == null || cellaCognome.Value == string.Empty)
            {
                cellaCognome.ErrorText = "Il cognome è obbligatorio";
            }
        }

        private void tsbtn_apriCSV_Click(object sender, EventArgs e)
        {
            var dlgResult = openFileDialog1.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                AssociaDataSource();
            }
           

        }

        private void aggiungiPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            var f = new Form2();          
            f.ShowDialog();
        }
    }
}
