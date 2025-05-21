using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garica0211
{
    public partial class LogGrid: Form
    {
        public LogGrid()
        {
            InitializeComponent();
            LoadExcelFile();
        }
        public void LoadExcelFile()
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\DataSheet.xlsx");
            Worksheet sheet = book.Worksheets[1];
            DataTable dt = sheet.ExportDataTable();
            dtgLog.DataSource = dt;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard f1 = new DashBoard();
            f1.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
