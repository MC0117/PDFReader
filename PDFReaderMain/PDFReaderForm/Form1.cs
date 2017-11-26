﻿using System;
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
            MessageBox.Show(Directory.GetCurrentDirectory());
            MessageBox.Show(Directory.GetDirectoryRoot(Directory.GetCurrentDirectory()));

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
                string chosenFile = ofdImportFile.FileName;
                txtFilePath.Text = chosenFile;
                input = CreatePDFDocument(chosenFile);
                nudStartPage.Maximum = input.PageCount;
                nudEndPage.Maximum = input.PageCount;
                btnSplit.Enabled = !(txtNewFilePath.Text == "") ? true: false;
            }
        }
        private void btnSplit_Click(object sender, EventArgs e)
        {
            string initialDirectory = Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(txtNewFilePath.Text);
            if (txtSplitFileName.Text == "")
            {
                MessageBox.Show("You need to give the new file a name");
            }
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

            for (int i = (int)nudStartPage.Value; i <= nudEndPage.Value; i++)
            {
                output.AddPage(input.Pages[i]);
            }
            output.Save(txtSplitFileName.Text + ".pdf");
            MessageBox.Show("Your PDF-File has successfully been separated.");
            Directory.SetCurrentDirectory(initialDirectory);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr = fbdBrowsingDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtNewFilePath.Text = fbdBrowsingDialog.SelectedPath;
                btnSplit.Enabled = !(txtFilePath.Text == "") ? true : false;
            }
        }
    }
}
