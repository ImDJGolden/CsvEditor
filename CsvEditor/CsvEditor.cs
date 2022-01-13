using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvEditor
{
    public partial class CsvEditor : Form
    {
        public CsvEditor()
        {
            InitializeComponent();

            cbxSeperator.DataSource = Csv.xDelimiter;
            cbxSeperator.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSeperator.SelectedIndex = 1;

            txtAddColumn.Text = "\"kolom naam...\"";

        }

        #region Buttons

        private void btnImportFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bevat de CSV die je wilt importeren een header? \n\nYes: Met headers. \nNo: zonder headers.", "Importeren.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ImportExport.OpenCsvFile(true);     //Headers in CSV
                }
                else if (result == DialogResult.No)
                {
                    ImportExport.OpenCsvFile(false);    //No headers in CSV
                }

                txtCsvFile.Text = Csv.xFilename;
                dgvCsvFile.DataSource = Csv.xData;
                if (Csv.xData != null)
                { 
                    lblRecords.Text = Csv.xData.Rows.Count.ToString();
                    btnMerge.Enabled = true;
                }
                else { lblRecords.Text = "0"; }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  

        private void btnMergeFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bevat de CSV die je wilt samenvoegen een header? \n\nYes: Met headers. \nNo: zonder headers.", "Samenvoegen.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ImportExport.MergeCsvFile(true);
                }
                else if (result == DialogResult.No)
                {
                    ImportExport.MergeCsvFile(false);
                }

                dgvCsvFile.Refresh();
                txtCsvFile.Text = Csv.xFilename;
                lblRecords.Text = Csv.xData.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Exporteren met of zonder headers? \n\nYes: Met headers. \nNo: zonder headers.", "Export.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                }
                else if (result == DialogResult.No)
                {
                    ImportExport.ExportCsvFileNoHeader(dgvCsvFile, cbxSeperator.SelectedValue.ToString());
                }

                dgvCsvFile.Refresh();
                txtCsvFile.Text = Csv.xFilename;
                lblRecords.Text = Csv.xData.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            if (txtAddColumn.Text != "\"kolom naam...\"")
            {
                if (Csv.xData != null)
                {
                    Csv.xData.Columns.Add(txtAddColumn.Text);
                    dgvCsvFile.DataSource = Csv.xData;
                    txtAddColumn.Text = "\"kolom naam...\"";
                }
                else
                {
                    Csv.xData = new DataTable();

                    Csv.xData.Columns.Add(txtAddColumn.Text);
                    dgvCsvFile.DataSource = Csv.xData;
                    txtAddColumn.Text = "\"kolom naam...\"";
                }
            }
            else
            {
                MessageBox.Show("Vul eerst een kolom naam.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveColumn_Click(object sender, EventArgs e)
        {
            int colIndex = dgvCsvFile.CurrentCell.ColumnIndex;
            string colName = dgvCsvFile.Columns[colIndex].HeaderText;

            DialogResult result = MessageBox.Show($"Bent u zeker dat u de kolom \"{colName}\" wilt verwijderen?", "Verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Csv.xData.Columns.RemoveAt(colIndex);
                dgvCsvFile.DataSource = Csv.xData;
            }

        }

        private void btnClearDgv_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bent u zeker dat u de 'DataGridView' wilt leegmaken?", "Opgelet!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Csv.xData = null;
                txtCsvFile.Text = null;
                dgvCsvFile.DataSource = null;
                dgvCsvFile.Refresh();
                lblRecords.Text = "0";
                btnMerge.Enabled = false;
            }
        }

        #endregion

        #region Extra

        public void RemoveText(object sender, EventArgs e)
        {
            if (txtAddColumn.Text == "\"kolom naam...\"")
            {
                txtAddColumn.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e) 
        {
            if (string.IsNullOrWhiteSpace(txtAddColumn.Text))
            {
                txtAddColumn.Text = "\"kolom naam...\"";
            }
        }


        #endregion

        
    }
}