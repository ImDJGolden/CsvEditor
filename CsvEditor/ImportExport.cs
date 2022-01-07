using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvEditor
{
    class ImportExport
    {
        #region Import

        public static DataTable dtImport = new DataTable();

        public static DataTable ImportCSVheader(string filename)
        {
            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(filename))
                {
                    csvReader.SetDelimiters(new string[] { ";" });
                    csvReader.HasFieldsEnclosedInQuotes = true;

                    // *** Read columns from CSV ***
                    string[] colFields = csvReader.ReadFields();

                    foreach (string column in colFields)
                    {
                        DataColumn dc = new DataColumn(column);
                        dtImport.Columns.Add(dc);
                    }

                    // *** Read datarows from CSV ***
                    while (!csvReader.EndOfData)
                    {
                        string[] dataFields = csvReader.ReadFields();
                        //DataRow dr = dtImport.NewRow();

                        for (int i = 0; i <= dataFields.Length - 1; i++)
                        {
                            if (dataFields[i] == null)
                            {
                                //Null value found in csv
                            }
                            else
                            {
                                dtImport.Rows.Add(dataFields[i]);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return dtImport;
        }

        public static DataTable ImportCSVNoHeader(string filename)
        {
            return dtImport;
        } //TODO

        public static void OpenCsvFile(bool header)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();

                if (dialog.FileName != "")
                {
                    if (dialog.FileName.EndsWith(".csv"))
                    {
                        Csv.xFilename = dialog.FileName;
                        DataTable dt = new DataTable();

                        if (header)
                        {
                            dt = ImportCSVheader(Csv.xFilename);
                        }
                        else if (!header)
                        {
                            dt = ImportCSVNoHeader(Csv.xFilename);
                        }

                        Csv.xData = dt;
                    }
                    else
                    {
                        MessageBox.Show("Gekozen bestand is ongeldig. Kies een csv Bestand.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Export



        #endregion
    }
}
