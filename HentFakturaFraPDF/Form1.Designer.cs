namespace HentFakturaFraPDF
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
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.ofdPDF = new System.Windows.Forms.OpenFileDialog();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSimnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMANR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbBottom = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFile.Location = new System.Drawing.Point(419, 12);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFile.TabIndex = 102;
            this.btnBrowseFile.Text = "Åben fil";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(497, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 105;
            this.btnRun.Text = "Kør";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(12, 16);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(47, 16);
            this.lblFilePath.TabIndex = 106;
            this.lblFilePath.Text = "Sti til fil";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(66, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(347, 22);
            this.txtFilePath.TabIndex = 101;
            // 
            // ofdPDF
            // 
            this.ofdPDF.DefaultExt = "*.pdf";
            this.ofdPDF.FileName = "*.pdf";
            this.ofdPDF.Title = "Åben PDF";
            this.ofdPDF.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdPDF_FileOk);
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.AllowUserToResizeRows = false;
            this.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colName,
            this.colNetto,
            this.colSimnumber,
            this.colCurrentEmployee,
            this.colMANR});
            this.dgvOutput.Location = new System.Drawing.Point(12, 40);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowHeadersVisible = false;
            this.dgvOutput.RowTemplate.Height = 24;
            this.dgvOutput.Size = new System.Drawing.Size(560, 339);
            this.dgvOutput.TabIndex = 107;
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "Nummer";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Navn";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colNetto
            // 
            this.colNetto.HeaderText = "Netto";
            this.colNetto.Name = "colNetto";
            this.colNetto.ReadOnly = true;
            // 
            // colSimnumber
            // 
            this.colSimnumber.HeaderText = "SIMnummer";
            this.colSimnumber.Name = "colSimnumber";
            this.colSimnumber.ReadOnly = true;
            // 
            // colCurrentEmployee
            // 
            this.colCurrentEmployee.HeaderText = "Medarbejder";
            this.colCurrentEmployee.Name = "colCurrentEmployee";
            this.colCurrentEmployee.ReadOnly = true;
            // 
            // colMANR
            // 
            this.colMANR.HeaderText = "MANR";
            this.colMANR.Name = "colMANR";
            this.colMANR.ReadOnly = true;
            // 
            // pbBottom
            // 
            this.pbBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbBottom.Location = new System.Drawing.Point(0, 381);
            this.pbBottom.Name = "pbBottom";
            this.pbBottom.Size = new System.Drawing.Size(584, 10);
            this.pbBottom.Step = 1;
            this.pbBottom.TabIndex = 109;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 391);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.pbBottom);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.txtFilePath);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "HentFakturaFraPDF";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog ofdPDF;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSimnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMANR;
        private System.Windows.Forms.ProgressBar pbBottom;
    }
}

