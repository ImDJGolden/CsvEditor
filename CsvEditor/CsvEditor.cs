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
            string filename = "";
            DataTable dt = new DataTable();

            try
            {
                DialogResult result = MessageBox.Show("Bevat de CSV die je wilt importeren een header? \n\nYes: Met headers. \nNo: zonder headers.", "Wat voor CSV?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    filename = ImportExport.OpenCsvFile();
                    dt = ImportExport.ImportCSVheader(filename);
                }
                else if (result == DialogResult.No)
                {
                    //TODO: ImportCSVNoHeader
                }

                txtCsvFile.Text = filename;

                if (dt.Rows != null && dt.Rows.ToString() != String.Empty)
                {
                    dgvCsvFile.DataSource = dt;
                }

                if (dgvCsvFile.Rows.Count == 0)
                {
                    MessageBox.Show("Geen data in csv bestand!", "Warning.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
