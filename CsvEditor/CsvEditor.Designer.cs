
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
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.btnRemoveColumn = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.cbxSeperator = new System.Windows.Forms.ComboBox();
            this.txtAddColumn = new System.Windows.Forms.TextBox();
            this.gbxAddColumn = new System.Windows.Forms.GroupBox();
            this.cbxTypeof = new System.Windows.Forms.ComboBox();
            this.gbxExport = new System.Windows.Forms.GroupBox();
            this.gbxRemoveColumn = new System.Windows.Forms.GroupBox();
            this.gbxRemoveRow = new System.Windows.Forms.GroupBox();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.gbxRenameColumn = new System.Windows.Forms.GroupBox();
            this.txtRenameColumn = new System.Windows.Forms.TextBox();
            this.btnRenameColumn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsvFile)).BeginInit();
            this.gbxAddColumn.SuspendLayout();
            this.gbxExport.SuspendLayout();
            this.gbxRemoveColumn.SuspendLayout();
            this.gbxRemoveRow.SuspendLayout();
            this.gbxRenameColumn.SuspendLayout();
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
            this.dgvCsvFile.Size = new System.Drawing.Size(1167, 611);
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
            this.txtCsvFile.Size = new System.Drawing.Size(697, 20);
            this.txtCsvFile.TabIndex = 2;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(920, 10);
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
            this.btnClearDgv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearDgv.Location = new System.Drawing.Point(1130, 10);
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
            this.btnMerge.Location = new System.Drawing.Point(989, 10);
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
            // btnAddColumn
            // 
            this.btnAddColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddColumn.Location = new System.Drawing.Point(84, 73);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(94, 79);
            this.btnAddColumn.TabIndex = 8;
            this.btnAddColumn.Text = "Toevoegen";
            this.btnAddColumn.UseVisualStyleBackColor = false;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // btnRemoveColumn
            // 
            this.btnRemoveColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveColumn.Location = new System.Drawing.Point(84, 15);
            this.btnRemoveColumn.Name = "btnRemoveColumn";
            this.btnRemoveColumn.Size = new System.Drawing.Size(94, 79);
            this.btnRemoveColumn.TabIndex = 9;
            this.btnRemoveColumn.Text = "Verwijder   Kolom";
            this.btnRemoveColumn.UseVisualStyleBackColor = false;
            this.btnRemoveColumn.Click += new System.EventHandler(this.btnRemoveColumn_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExport.Location = new System.Drawing.Point(6, 47);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(172, 29);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Exporteer";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblSeperator
            // 
            this.lblSeperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeperator.AutoSize = true;
            this.lblSeperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeperator.Location = new System.Drawing.Point(6, 21);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(74, 15);
            this.lblSeperator.TabIndex = 12;
            this.lblSeperator.Text = "Seperator:";
            // 
            // cbxSeperator
            // 
            this.cbxSeperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSeperator.DropDownHeight = 110;
            this.cbxSeperator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxSeperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSeperator.FormattingEnabled = true;
            this.cbxSeperator.IntegralHeight = false;
            this.cbxSeperator.Location = new System.Drawing.Point(103, 18);
            this.cbxSeperator.Name = "cbxSeperator";
            this.cbxSeperator.Size = new System.Drawing.Size(75, 23);
            this.cbxSeperator.TabIndex = 13;
            // 
            // txtAddColumn
            // 
            this.txtAddColumn.ForeColor = System.Drawing.Color.Gray;
            this.txtAddColumn.Location = new System.Drawing.Point(6, 19);
            this.txtAddColumn.Name = "txtAddColumn";
            this.txtAddColumn.Size = new System.Drawing.Size(172, 20);
            this.txtAddColumn.TabIndex = 14;
            this.txtAddColumn.Enter += new System.EventHandler(this.RemoveTextNewColumn);
            this.txtAddColumn.Leave += new System.EventHandler(this.AddTextNewColumn);
            // 
            // gbxAddColumn
            // 
            this.gbxAddColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAddColumn.Controls.Add(this.cbxTypeof);
            this.gbxAddColumn.Controls.Add(this.btnAddColumn);
            this.gbxAddColumn.Controls.Add(this.txtAddColumn);
            this.gbxAddColumn.Location = new System.Drawing.Point(1188, 38);
            this.gbxAddColumn.Name = "gbxAddColumn";
            this.gbxAddColumn.Size = new System.Drawing.Size(184, 157);
            this.gbxAddColumn.TabIndex = 15;
            this.gbxAddColumn.TabStop = false;
            this.gbxAddColumn.Text = "Kolom toevoegen";
            // 
            // cbxTypeof
            // 
            this.cbxTypeof.FormattingEnabled = true;
            this.cbxTypeof.Location = new System.Drawing.Point(6, 46);
            this.cbxTypeof.Name = "cbxTypeof";
            this.cbxTypeof.Size = new System.Drawing.Size(172, 21);
            this.cbxTypeof.TabIndex = 15;
            // 
            // gbxExport
            // 
            this.gbxExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxExport.Controls.Add(this.btnExport);
            this.gbxExport.Controls.Add(this.lblSeperator);
            this.gbxExport.Controls.Add(this.cbxSeperator);
            this.gbxExport.Location = new System.Drawing.Point(1188, 567);
            this.gbxExport.Name = "gbxExport";
            this.gbxExport.Size = new System.Drawing.Size(184, 82);
            this.gbxExport.TabIndex = 16;
            this.gbxExport.TabStop = false;
            this.gbxExport.Text = "Export";
            // 
            // gbxRemoveColumn
            // 
            this.gbxRemoveColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxRemoveColumn.Controls.Add(this.btnRemoveColumn);
            this.gbxRemoveColumn.Location = new System.Drawing.Point(1188, 341);
            this.gbxRemoveColumn.Name = "gbxRemoveColumn";
            this.gbxRemoveColumn.Size = new System.Drawing.Size(184, 100);
            this.gbxRemoveColumn.TabIndex = 17;
            this.gbxRemoveColumn.TabStop = false;
            this.gbxRemoveColumn.Text = "Kolom verwijderen";
            // 
            // gbxRemoveRow
            // 
            this.gbxRemoveRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxRemoveRow.Controls.Add(this.btnRemoveRow);
            this.gbxRemoveRow.Location = new System.Drawing.Point(1188, 447);
            this.gbxRemoveRow.Name = "gbxRemoveRow";
            this.gbxRemoveRow.Size = new System.Drawing.Size(184, 100);
            this.gbxRemoveRow.TabIndex = 18;
            this.gbxRemoveRow.TabStop = false;
            this.gbxRemoveRow.Text = "Record verwijderen";
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveRow.Location = new System.Drawing.Point(84, 15);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(94, 79);
            this.btnRemoveRow.TabIndex = 9;
            this.btnRemoveRow.Text = "Verwijder Record";
            this.btnRemoveRow.UseVisualStyleBackColor = false;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // gbxRenameColumn
            // 
            this.gbxRenameColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxRenameColumn.Controls.Add(this.txtRenameColumn);
            this.gbxRenameColumn.Controls.Add(this.btnRenameColumn);
            this.gbxRenameColumn.Location = new System.Drawing.Point(1188, 201);
            this.gbxRenameColumn.Name = "gbxRenameColumn";
            this.gbxRenameColumn.Size = new System.Drawing.Size(184, 134);
            this.gbxRenameColumn.TabIndex = 18;
            this.gbxRenameColumn.TabStop = false;
            this.gbxRenameColumn.Text = "Kolom hernoemen";
            // 
            // txtRenameColumn
            // 
            this.txtRenameColumn.ForeColor = System.Drawing.Color.Gray;
            this.txtRenameColumn.Location = new System.Drawing.Point(6, 19);
            this.txtRenameColumn.Name = "txtRenameColumn";
            this.txtRenameColumn.Size = new System.Drawing.Size(172, 20);
            this.txtRenameColumn.TabIndex = 15;
            this.txtRenameColumn.Enter += new System.EventHandler(this.RemoveTextRenameColumn);
            this.txtRenameColumn.Leave += new System.EventHandler(this.AddTextRenameColumn);
            // 
            // btnRenameColumn
            // 
            this.btnRenameColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenameColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRenameColumn.Location = new System.Drawing.Point(84, 45);
            this.btnRenameColumn.Name = "btnRenameColumn";
            this.btnRenameColumn.Size = new System.Drawing.Size(94, 79);
            this.btnRenameColumn.TabIndex = 9;
            this.btnRenameColumn.Text = "Hernoem   Kolom";
            this.btnRenameColumn.UseVisualStyleBackColor = false;
            this.btnRenameColumn.Click += new System.EventHandler(this.btnRenameColumn_Click);
            // 
            // CsvEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.gbxRenameColumn);
            this.Controls.Add(this.gbxRemoveRow);
            this.Controls.Add(this.gbxRemoveColumn);
            this.Controls.Add(this.gbxExport);
            this.Controls.Add(this.gbxAddColumn);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnClearDgv);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtCsvFile);
            this.Controls.Add(this.lblCsvFile);
            this.Controls.Add(this.dgvCsvFile);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "CsvEditor";
            this.Text = "CSV Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsvFile)).EndInit();
            this.gbxAddColumn.ResumeLayout(false);
            this.gbxAddColumn.PerformLayout();
            this.gbxExport.ResumeLayout(false);
            this.gbxExport.PerformLayout();
            this.gbxRemoveColumn.ResumeLayout(false);
            this.gbxRemoveRow.ResumeLayout(false);
            this.gbxRenameColumn.ResumeLayout(false);
            this.gbxRenameColumn.PerformLayout();
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
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.Button btnRemoveColumn;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblSeperator;
        private System.Windows.Forms.ComboBox cbxSeperator;
        private System.Windows.Forms.TextBox txtAddColumn;
        private System.Windows.Forms.GroupBox gbxAddColumn;
        private System.Windows.Forms.GroupBox gbxExport;
        private System.Windows.Forms.GroupBox gbxRemoveColumn;
        private System.Windows.Forms.GroupBox gbxRemoveRow;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.ComboBox cbxTypeof;
        private System.Windows.Forms.GroupBox gbxRenameColumn;
        private System.Windows.Forms.Button btnRenameColumn;
        private System.Windows.Forms.TextBox txtRenameColumn;
    }
}

