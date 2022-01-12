using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
                    csvReader.SetDelimiters(Csv.xDelimiter);
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
                string[] lines = File.ReadAllLines(filename);

                using (TextFieldParser csvReader = new TextFieldParser(filename))
                {
                    csvReader.SetDelimiters(Csv.xDelimiter);
                    csvReader.HasFieldsEnclosedInQuotes = true;

                    // *** Add Columns ***
                    int cols = 0;

                    foreach (string delimiter in Csv.xDelimiter)
                    {
                        cols += lines[0].Split(Convert.ToChar(delimiter)).Count();
                    }

                    for (int i = 0; i <= cols - 2 ; i++)
                    {
                        dtImport.Columns.Add($"column {i + 1}");
                    }

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

        public static DataTable ImportCSVNoHeader(string filename, bool merge) //Read data in CSV file (without headers) and copies the existing headers
        {
            DataTable dtImport = new DataTable();

            try
            {
                string[] lines = File.ReadAllLines(filename);

                using (TextFieldParser csvReader = new TextFieldParser(filename))
                {
                    csvReader.SetDelimiters(Csv.xDelimiter);
                    csvReader.HasFieldsEnclosedInQuotes = true;

                    // *** Add Columns ***
                    int cols = 0;

                    foreach (string delimiter in Csv.xDelimiter)
                    {
                        cols += lines[0].Split(Convert.ToChar(delimiter)).Count();
                    }
                    if (merge)
                    {
                        for (int i = 0; i <= cols - 2; i++)
                        {
                            dtImport.Columns.Add($"{Csv.xData.Columns[i].ColumnName}");
                        }
                    }

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

                if (dialog.ShowDialog() == DialogResult.OK)
                {
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
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void MergeCsvFile(bool header) //Open FileDialog to choose a merge file
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
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
                                DialogResult result = MessageBox.Show("Wil je de column namen overnemen?", "Samenvoegen.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {
                                    dt = ImportCSVNoHeader(Csv.xFilename, true);
                                }
                                else if (result == DialogResult.No)
                                {
                                    dt = ImportCSVNoHeader(Csv.xFilename);
                                }
                            }

                            Csv.xData.Merge(dt);
                        }
                        else
                        {
                            MessageBox.Show("Gekozen bestand is ongeldig. Kies een csv Bestand.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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

        public static void ExportCsvFile(DataGridView dgv, string delimiter) //Export without headers.
        {
            string path = "";
            StreamWriter sw = null;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV|*.csv";
            sfd.FileName = "OutputCsv.csv";
            sfd.Title = "CSV-bestand opslaan";

            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;

                    if (Csv.xData.Rows.Count != 0)
                    {
                        // *** Get Columns in order of DGV ***
                        List<DataGridViewColumn> columnsInOrder = new List<DataGridViewColumn>();
                        List<string> csvExportLines = new List<string>();

                        foreach (DataGridViewColumn c in dgv.Columns)
                        {
                            columnsInOrder.Add(c);
                        }

                        columnsInOrder = columnsInOrder.OrderBy(c => c.DisplayIndex).ToList();

                        foreach (DataGridViewRow r in dgv.Rows)
                        {
                            List<string> rowsInOrder = new List<string>();

                            foreach (DataGridViewColumn c in columnsInOrder)
                            {
                                if (!r.IsNewRow)
                                {
                                    rowsInOrder.Add(r.Cells[c.Index].Value.ToString());
                                }
                            }

                            csvExportLines.Add(string.Join(delimiter, rowsInOrder.ToArray()));
                        }

                        sw = File.AppendText(path);

                        for (int i = 0; i < csvExportLines.Count - 1; i++)
                        {
                            sw.WriteLine(csvExportLines[i]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sw.Close();
            }
        }

        //ExportCsvFileWithHeaders

        #endregion
    }
}
