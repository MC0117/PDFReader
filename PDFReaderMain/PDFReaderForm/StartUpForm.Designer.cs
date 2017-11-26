namespace PDFReaderForm
{
    partial class StartUpForm
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
            this.btnConvertTxt = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvertTxt
            // 
            this.btnConvertTxt.Location = new System.Drawing.Point(31, 123);
            this.btnConvertTxt.Name = "btnConvertTxt";
            this.btnConvertTxt.Size = new System.Drawing.Size(75, 23);
            this.btnConvertTxt.TabIndex = 0;
            this.btnConvertTxt.Text = "Convert .txt";
            this.btnConvertTxt.UseVisualStyleBackColor = true;
            this.btnConvertTxt.Click += new System.EventHandler(this.btnConvertTxt_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(31, 80);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 1;
            this.btnSplit.Text = "Split .pdf-file";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 167);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnConvertTxt);
            this.Name = "StartUpForm";
            this.Text = "StartUpForm";
            this.Load += new System.EventHandler(this.StartUpForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConvertTxt;
        private System.Windows.Forms.Button btnSplit;
    }
}