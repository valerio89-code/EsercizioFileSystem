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
        const string filePath = @"C:\Corso c#\esempio.csv";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("nome", "NOME");
            dataGridView1.Columns.Add("cognome", "COGNOME");
            dataGridView1.Columns.Add("dataNascita", "DATA DI NASCITA");
            dataGridView1.Columns.Add("comune", "COMUNE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = tbx_nome.Text;
            var cognome = tbx_cognome.Text;
            var dataNascita = dpk_nascita.Value;
            var comune = tbx_comune.Text;
            using (var streamWriter = new StreamWriter(filePath, true))
            {
                streamWriter.WriteLine($"{nome},{cognome},{dataNascita.ToShortDateString()},{comune}");
                streamWriter.FlushAsync();
            }

            foreach (var item in this.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
                if(item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }

            MessageBox.Show("Salvataggio eseguito con successo", "COMPLIMENTI");
        }

        private void btn_mostraCSV_Click(object sender, EventArgs e)
        {           
            dataGridView1.Rows.Clear();
            using (var streamReader = new StreamReader(filePath))
            {
                while (true)
                {
                    var line = streamReader.ReadLine();
                    if (line == null) break;
                    //gianni,mina,31/10/2024,iglesias
                    //[gianni, mina, 31/10/20124, iglesias]
                    string[] splittedLine = line.Split(',');
                    dataGridView1.Rows.Add(splittedLine);
                }
            }
        }
    }
}
