using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;


namespace PDFReaderForm
{
    public partial class TextConvertForm : Form
    {
        PdfDocument input = null;
        public TextConvertForm()
        {
            InitializeComponent();
        }

        private void TextConvertForm_Load(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdImportDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtPDFPath.Text = ofdImportDialog.FileName;
                input = PdfReader.Open(ofdImportDialog.FileName, PdfDocumentOpenMode.Import);
                btnTxtConvert.Enabled = true;
            }
        }

        private void btnTxtConvert_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < input.PageCount; i++)
            {
                PdfPage page = input.Pages[i];
                IEnumerable<string> pageText = page.ExtractText();
            }
        }
    }
}
