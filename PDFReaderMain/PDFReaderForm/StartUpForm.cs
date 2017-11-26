using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFReaderForm
{
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();
        }

        private void StartUpForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            PDFReaderForm SplitForm = new PDFReaderForm();
            SplitForm.Show();
        }

        private void btnConvertTxt_Click(object sender, EventArgs e)
        {
            TextConvertForm TxtConversionForm = new TextConvertForm();
            TxtConversionForm.Show();
        }
    }
}
