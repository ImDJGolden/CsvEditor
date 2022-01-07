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
                DialogResult result = MessageBox.Show("Bevat de CSV die je wilt importeren een header?", "Wat voor CSV?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                }
                else if (result == DialogResult.No)
                {

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
