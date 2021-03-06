using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace CsvEditor
{
    public partial class CsvEditor : Form
    {
        public string placeholderNewColumn = "\"kolom naam...\"";
        public string placeholderRenameColumn = "\"Nieuwe kolom naam...\"";

        public CsvEditor()
        {
            InitializeComponent();

            txtAddColumn.Text = placeholderNewColumn;
            txtRenameColumn.Text = placeholderRenameColumn;

            //Dropdown Delimiter -> Export to csv
            cbxSeperator.DataSource = Csv.xDelimiter;
            cbxSeperator.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSeperator.SelectedIndex = 1;

            //Dropdown Type -> New Column
            cbxTypeof.DataSource = Csv.xDataTypes;
            cbxTypeof.DropDownStyle = ComboBoxStyle.DropDownList;
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
                Log.Write(ex.Message);
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
                Log.Write(ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                ImportExport.ExportCsvFileHeader(dgvCsvFile, cbxSeperator.SelectedValue.ToString());

                MessageBox.Show("Alle data is succesvol geëxporteerd.", "Export Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                dgvCsvFile.Refresh();
                txtCsvFile.Text = Csv.xFilename;
                lblRecords.Text = Csv.xData.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Write(ex.Message);
            }
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Csv.xData == null)
                {
                    Csv.xData = new DataTable();
                }

                if (txtAddColumn.Text != placeholderNewColumn)
                {
                    switch (cbxTypeof.SelectedValue.ToString())
                    {
                        case "Tekst":           //String
                            Csv.xData.Columns.Add(txtAddColumn.Text, typeof(string));
                            break;
                        case "Nummeriek":       //Integer
                            Csv.xData.Columns.Add(txtAddColumn.Text, typeof(int));
                            break;
                        case "Decimaal":        //Double
                            Csv.xData.Columns.Add(txtAddColumn.Text, typeof(double));
                            break;
                        case "Datumtijd":       //DateTime
                            Csv.xData.Columns.Add(txtAddColumn.Text, typeof(DateTime));
                            break;
                        case "Boolean":         //Boolean
                            Csv.xData.Columns.Add(txtAddColumn.Text, typeof(bool));
                            break;
                        default:                //Default case
                            Csv.xData.Columns.Add(txtAddColumn.Text);
                            break;
                    }

                    dgvCsvFile.DataSource = Csv.xData;
                    txtAddColumn.Text = placeholderNewColumn;
                }
                else
                {
                    MessageBox.Show("Vul eerst een kolom naam in.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Write(ex.Message);
            }
        }

        private void btnRenameColumn_Click(object sender, EventArgs e)
        {
            int colIndex = dgvCsvFile.CurrentCell.ColumnIndex;
            string colName = dgvCsvFile.Columns[colIndex].HeaderText;

            if (txtRenameColumn.Text != placeholderRenameColumn)
            {
                if (txtRenameColumn.Text != colName)
                {
                    DialogResult result = MessageBox.Show($"Bent u zeker dat u de kolom \"{colName}\" wilt hernoemen naar \"{txtRenameColumn.Text}\"?", "Verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Csv.xData.Columns[colIndex].ColumnName = txtRenameColumn.Text;
                    }

                    dgvCsvFile.DataSource = Csv.xData;
                    txtRenameColumn.Text = placeholderRenameColumn;
                }
                else
                {
                    MessageBox.Show("Vul eerst een nieuwe kolom naam in.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vul eerst een nieuwe kolom naam in.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveColumn_Click(object sender, EventArgs e)
        {
            int colIndex = dgvCsvFile.CurrentCell.ColumnIndex;
            string colName = dgvCsvFile.Columns[colIndex].HeaderText;

            DialogResult result = MessageBox.Show($"Bent u zeker dat u de kolom \"{colName}\" wilt verwijderen?", "Verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (result == DialogResult.Yes)
                {
                    Csv.xData.Columns.RemoveAt(colIndex);
                    dgvCsvFile.DataSource = Csv.xData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Write(ex.Message);
            }
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvCsvFile.CurrentCell.RowIndex;

            DialogResult result = MessageBox.Show($"Bent u zeker dat u record \"{rowIndex + 1}\" wilt verwijderen?", "Verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (result == DialogResult.Yes)
                {
                    dgvCsvFile.Rows.RemoveAt(rowIndex);
                    lblRecords.Text = Csv.xData.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Write(ex.Message);
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
        // *** Placeholder txtNewColumn ***
        public void RemoveTextNewColumn(object sender, EventArgs e)
        {
            txtAddColumn.ForeColor = Color.Black;

            if (txtAddColumn.Text == placeholderNewColumn)
            {
                txtAddColumn.Text = "";
            }
        }
        public void AddTextNewColumn(object sender, EventArgs e) 
        {
            if (string.IsNullOrWhiteSpace(txtAddColumn.Text))
            {
                txtAddColumn.ForeColor = Color.Gray;
                txtAddColumn.Text = placeholderNewColumn;
            }
        }

        // *** Placeholder txtRenameColumn ***
        private void RemoveTextRenameColumn(object sender, EventArgs e)
        {
            txtRenameColumn.ForeColor = Color.Black;

            if (txtRenameColumn.Text == placeholderRenameColumn)
            {
                txtRenameColumn.Text = "";
            }
        }
        private void AddTextRenameColumn(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRenameColumn.Text))
            {
                txtRenameColumn.ForeColor = Color.Gray;
                txtRenameColumn.Text = placeholderRenameColumn;
            }
        }
        #endregion
    }
}