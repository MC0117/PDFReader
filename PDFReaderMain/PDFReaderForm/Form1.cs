using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;

namespace PDFReaderForm
{
    public partial class PDFReaderForm : Form
    {
        PdfDocument input = null;
        PdfDocument output = null;
        public PDFReaderForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private PdfDocument CreatePDFDocument(string fileName)
        {
            return PdfReader.Open(fileName, PdfDocumentOpenMode.Import);
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdImportFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtSplitFileName.Enabled = true;
                btnSplit.Enabled = true;
                string chosenFile = ofdImportFile.FileName;
                txtFilePath.Text = chosenFile;
                input = CreatePDFDocument(chosenFile);
                nudStartPage.Maximum = input.PageCount;
                nudEndPage.Maximum = input.PageCount;
            }
        }
        private void btnSplit_Click(object sender, EventArgs e)
        {
            output = new PdfDocument();
            output.Version = input.Version;
            output.Info.Title = txtSplitFileName.Text;
            output.Info.Creator = input.Info.Creator;

            //Inefficent, find better solution
            if (nudStartPage.Value > nudEndPage.Value)
            {
                decimal neutral = nudEndPage.Value;
                nudEndPage.Value = nudStartPage.Value;
                nudStartPage.Value = neutral;
            }
            for (int i = (int)nudStartPage.Value; i < nudEndPage.Value; i++)
            {
                output.AddPage(input.Pages[i]);
            }
            output.Save(txtSplitFileName.Text + ".pdf");
            MessageBox.Show("Your PDF-File has successfully been separated.");
        }
    }
}
