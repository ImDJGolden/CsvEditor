
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
            this.btnImportFile = new System.Windows.Forms.Button();
            this.btnClearDgv = new System.Windows.Forms.Button();
            this.btnMergeFile = new System.Windows.Forms.Button();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
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
            this.dgvCsvFile.Location = new System.Drawing.Point(13, 38);
            this.dgvCsvFile.Name = "dgvCsvFile";
            this.dgvCsvFile.Size = new System.Drawing.Size(907, 621);
            this.dgvCsvFile.TabIndex = 0;
            // 
            // lblCsvFile
            // 
            this.lblCsvFile.AutoSize = true;
            this.lblCsvFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCsvFile.Location = new System.Drawing.Point(170, 15);
            this.lblCsvFile.Name = "lblCsvFile";
            this.lblCsvFile.Size = new System.Drawing.Size(57, 13);
            this.lblCsvFile.TabIndex = 1;
            this.lblCsvFile.Text = "Bestand:";
            // 
            // txtCsvFile
            // 
            this.txtCsvFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCsvFile.Location = new System.Drawing.Point(236, 12);
            this.txtCsvFile.Name = "txtCsvFile";
            this.txtCsvFile.ReadOnly = true;
            this.txtCsvFile.Size = new System.Drawing.Size(437, 20);
            this.txtCsvFile.TabIndex = 2;
            // 
            // btnImportFile
            // 
            this.btnImportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportFile.Location = new System.Drawing.Point(679, 10);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(63, 23);
            this.btnImportFile.TabIndex = 3;
            this.btnImportFile.Text = "Importeer";
            this.btnImportFile.UseVisualStyleBackColor = true;
            this.btnImportFile.Click += new System.EventHandler(this.btnImportFile_Click);
            // 
            // btnClearDgv
            // 
            this.btnClearDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearDgv.Location = new System.Drawing.Point(870, 10);
            this.btnClearDgv.Name = "btnClearDgv";
            this.btnClearDgv.Size = new System.Drawing.Size(50, 23);
            this.btnClearDgv.TabIndex = 4;
            this.btnClearDgv.Text = "Clear";
            this.btnClearDgv.UseVisualStyleBackColor = true;
            this.btnClearDgv.Click += new System.EventHandler(this.btnClearDgv_Click);
            // 
            // btnMergeFile
            // 
            this.btnMergeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMergeFile.Enabled = false;
            this.btnMergeFile.Location = new System.Drawing.Point(748, 10);
            this.btnMergeFile.Name = "btnMergeFile";
            this.btnMergeFile.Size = new System.Drawing.Size(90, 23);
            this.btnMergeFile.TabIndex = 5;
            this.btnMergeFile.Text = "Samenvoegen";
            this.btnMergeFile.UseVisualStyleBackColor = true;
            this.btnMergeFile.Click += new System.EventHandler(this.btnMergeFile_Click);
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
            // CsvEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 671);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.btnMergeFile);
            this.Controls.Add(this.btnClearDgv);
            this.Controls.Add(this.btnImportFile);
            this.Controls.Add(this.txtCsvFile);
            this.Controls.Add(this.lblCsvFile);
            this.Controls.Add(this.dgvCsvFile);
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
        private System.Windows.Forms.Button btnImportFile;
        private System.Windows.Forms.Button btnClearDgv;
        private System.Windows.Forms.Button btnMergeFile;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label lblRecords;
    }
}

