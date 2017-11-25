using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;

namespace PDFReaderForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdImportFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnSplit.Enabled = true;
                string chosenFile = ofdImportFile.FileName;
                txtFilePath.Text = chosenFile;
                PdfDocument input = CreatePDFDocument(chosenFile);
                nudStartPage.Maximum = input.PageCount;
                nudEndPage.Maximum = input.PageCount;
            }
        }
        private PdfDocument CreatePDFDocument(string fileName)
        {
            return PdfReader.Open(fileName, PdfDocumentOpenMode.Import);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
               
        }
    }
}
