namespace PDFReaderForm
{
    partial class TextConvertForm
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
            this.ofdImportDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtPDFPath = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblTxtPath = new System.Windows.Forms.Label();
            this.bgwReader = new System.ComponentModel.BackgroundWorker();
            this.btnTxtConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdImportDialog
            // 
            this.ofdImportDialog.FileName = "openFileDialog1";
            // 
            // txtPDFPath
            // 
            this.txtPDFPath.Location = new System.Drawing.Point(25, 55);
            this.txtPDFPath.Name = "txtPDFPath";
            this.txtPDFPath.Size = new System.Drawing.Size(226, 20);
            this.txtPDFPath.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(25, 81);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblTxtPath
            // 
            this.lblTxtPath.AutoSize = true;
            this.lblTxtPath.Location = new System.Drawing.Point(54, 25);
            this.lblTxtPath.Name = "lblTxtPath";
            this.lblTxtPath.Size = new System.Drawing.Size(19, 13);
            this.lblTxtPath.TabIndex = 2;
            this.lblTxtPath.Text = "ba";
            // 
            // btnTxtConvert
            // 
            this.btnTxtConvert.Enabled = false;
            this.btnTxtConvert.Location = new System.Drawing.Point(35, 160);
            this.btnTxtConvert.Name = "btnTxtConvert";
            this.btnTxtConvert.Size = new System.Drawing.Size(103, 23);
            this.btnTxtConvert.TabIndex = 3;
            this.btnTxtConvert.Text = "Convert to .txt";
            this.btnTxtConvert.UseVisualStyleBackColor = true;
            this.btnTxtConvert.Click += new System.EventHandler(this.btnTxtConvert_Click);
            // 
            // TextConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnTxtConvert);
            this.Controls.Add(this.lblTxtPath);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtPDFPath);
            this.Name = "TextConvertForm";
            this.Text = "TextConvertForm";
            this.Load += new System.EventHandler(this.TextConvertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdImportDialog;
        private System.Windows.Forms.TextBox txtPDFPath;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblTxtPath;
        private System.ComponentModel.BackgroundWorker bgwReader;
        private System.Windows.Forms.Button btnTxtConvert;
    }
}