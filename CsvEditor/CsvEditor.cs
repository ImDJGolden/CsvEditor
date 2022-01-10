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
        }

        private void btnImportFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bevat de CSV die je wilt importeren een header? \n\nYes: Met headers. \nNo: zonder headers.", "Wat voor CSV?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

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
                lblRecords.Text = Csv.xData.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearDgv_Click(object sender, EventArgs e)
        {
            txtCsvFile.Text = null;
            dgvCsvFile.DataSource = null;
            dgvCsvFile.Refresh();
            lblRecords.Text = "0";
        }
    }
}