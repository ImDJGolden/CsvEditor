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

        public static DataTable ImportCSVheader(string filename) //Read data in CSV file (with headers)
        {
            DataTable dtImport = new DataTable();

            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(filename))
                {
                    csvReader.SetDelimiters(new string[] { ";", "," });
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

                        for (int i = 0; i <= dataFields.Length - 1; i++)
                        {
                            if (dataFields[i] == null || dataFields[i] == "")
                            {
                                //Null value found in CSV
                            }
                        }

                        dtImport.Rows.Add(dataFields);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return dtImport;
        }

        public static DataTable ImportCSVNoHeader(string filename) //Read data in CSV file (without headers)
        {
            DataTable dtImport = new DataTable();

            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(filename))
                {
                    csvReader.SetDelimiters(new string[] { ";", "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;

                    // *** Read datarows from CSV ***
                    while (!csvReader.EndOfData)
                    {
                        string[] dataFields = csvReader.ReadFields();

                        for (int i = 0; i <= dataFields.Length - 1; i++)
                        {
                            if (dataFields[i] == null)
                            {
                                //Null value found in csv
                            }
                        }

                        dtImport.Rows.Add(dataFields);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return dtImport;
        }

        public static void OpenCsvFile(bool header) //Open FileDialog to choose a CSV file
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

                        Csv.xData = null;

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

        #region Merge
        


        #endregion

        #region Export



        #endregion
    }
}
