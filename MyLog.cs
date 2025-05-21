using Spire.Spreadsheet.Forms.Actions;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garica0211
{
    internal class MyLog
    {
        private const string ExcelFilePath = @"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\DataSheet.xlsx";
        public string Message, Username;
        public void InsertLog(string user , string message)
        {
            Workbook book = new Workbook();  
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\DataSheet.xlsx");
            Worksheet sheet = book.Worksheets[1];

            int row = sheet.Rows.Length + 1;
            sheet.Range[row, 1].Value = Username;
            sheet.Range[row, 2].Value = Message;
            sheet.Range[row, 3].Value = DateTime.Now.ToString("MM/dd/yyyy");
            sheet.Range[row, 4].Value = DateTime.Now.ToString("hh : mm : ss : tt");
            book.SaveToFile(ExcelFilePath, ExcelVersion.Version2016);
        }
    }
}
