
namespace CsvEditor
{
    partial class CsvEditor
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
            this.dgvCsvFile = new System.Windows.Forms.DataGridView();
            this.lblCsvFile = new System.Windows.Forms.Label();
            this.txtCsvFile = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnClearDgv = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.pgbStatus = new System.Windows.Forms.ProgressBar();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.cbxSeperator = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsvFile)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCsvFile
            // 
            this.dgvCsvFile.AllowUserToOrderColumns = true;
            this.dgvCsvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCsvFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCsvFile.Location = new System.Drawing.Point(12, 38);
            this.dgvCsvFile.Name = "dgvCsvFile";
            this.dgvCsvFile.Size = new System.Drawing.Size(1103, 634);
            this.dgvCsvFile.TabIndex = 0;
            // 
            // lblCsvFile
            // 
            this.lblCsvFile.AutoSize = true;
            this.lblCsvFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCsvFile.Location = new System.Drawing.Point(151, 15);
            this.lblCsvFile.Name = "lblCsvFile";
            this.lblCsvFile.Size = new System.Drawing.Size(57, 13);
            this.lblCsvFile.TabIndex = 1;
            this.lblCsvFile.Text = "Bestand:";
            // 
            // txtCsvFile
            // 
            this.txtCsvFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCsvFile.Location = new System.Drawing.Point(217, 12);
            this.txtCsvFile.Name = "txtCsvFile";
            this.txtCsvFile.ReadOnly = true;
            this.txtCsvFile.Size = new System.Drawing.Size(633, 20);
            this.txtCsvFile.TabIndex = 2;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(856, 10);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(63, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Importeer";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImportFile_Click);
            // 
            // btnClearDgv
            // 
            this.btnClearDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearDgv.Location = new System.Drawing.Point(1066, 10);
            this.btnClearDgv.Name = "btnClearDgv";
            this.btnClearDgv.Size = new System.Drawing.Size(50, 23);
            this.btnClearDgv.TabIndex = 4;
            this.btnClearDgv.Text = "Clear";
            this.btnClearDgv.UseVisualStyleBackColor = true;
            this.btnClearDgv.Click += new System.EventHandler(this.btnClearDgv_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMerge.Enabled = false;
            this.btnMerge.Location = new System.Drawing.Point(925, 10);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(90, 23);
            this.btnMerge.TabIndex = 5;
            this.btnMerge.Text = "Samenvoegen";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMergeFile_Click);
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.Location = new System.Drawing.Point(12, 15);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(93, 13);
            this.lblTotalRecords.TabIndex = 6;
            this.lblTotalRecords.Text = "Totaal records:";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(111, 15);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(13, 13);
            this.lblRecords.TabIndex = 7;
            this.lblRecords.Text = "0";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1122, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 79);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1222, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 79);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(1122, 643);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(186, 29);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Exporteer";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pgbStatus
            // 
            this.pgbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbStatus.Location = new System.Drawing.Point(13, 678);
            this.pgbStatus.Name = "pgbStatus";
            this.pgbStatus.Size = new System.Drawing.Size(1295, 22);
            this.pgbStatus.TabIndex = 11;
            // 
            // lblSeperator
            // 
            this.lblSeperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeperator.AutoSize = true;
            this.lblSeperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeperator.Location = new System.Drawing.Point(1121, 581);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(74, 15);
            this.lblSeperator.TabIndex = 12;
            this.lblSeperator.Text = "Seperator:";
            // 
            // cbxSeperator
            // 
            this.cbxSeperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSeperator.DropDownHeight = 110;
            this.cbxSeperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSeperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSeperator.FormattingEnabled = true;
            this.cbxSeperator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxSeperator.IntegralHeight = false;
            this.cbxSeperator.Location = new System.Drawing.Point(1208, 578);
            this.cbxSeperator.Name = "cbxSeperator";
            this.cbxSeperator.Size = new System.Drawing.Size(61, 23);
            this.cbxSeperator.TabIndex = 13;
            // 
            // CsvEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 706);
            this.Controls.Add(this.cbxSeperator);
            this.Controls.Add(this.lblSeperator);
            this.Controls.Add(this.pgbStatus);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnClearDgv);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtCsvFile);
            this.Controls.Add(this.lblCsvFile);
            this.Controls.Add(this.dgvCsvFile);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "CsvEditor";
            this.Text = "CSV Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsvFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCsvFile;
        private System.Windows.Forms.Label lblCsvFile;
        private System.Windows.Forms.TextBox txtCsvFile;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnClearDgv;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ProgressBar pgbStatus;
        private System.Windows.Forms.Label lblSeperator;
        private System.Windows.Forms.ComboBox cbxSeperator;
    }
}

