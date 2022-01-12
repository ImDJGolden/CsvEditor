using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvEditor
{
    public static class Csv
    {
        public static string xFilename { get; set; }
        public static DataTable xData { get; set; }

        public static string[] xDelimiter = { ",", ";" };
    }
}
