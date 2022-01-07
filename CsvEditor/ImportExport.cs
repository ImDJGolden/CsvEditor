using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvEditor
{
    class ImportExport
    {
        #region Import

        public DataTable dtImport = new DataTable();

        private DataTable ImportCSVheader(string filename)
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

        #endregion

        #region Export



        #endregion
    }
}
