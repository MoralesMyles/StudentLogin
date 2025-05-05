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
    public partial class ActiveGrid: Form
    {
        public ActiveGrid()
        {
            InitializeComponent();
            LoadExcelFile();

        }
        public void LoadExcelFile()
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Garica0303\ref\DataSheet.xlsx");
            Worksheet sheet = book.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();
            dtgActive.DataSource = dt;

            int a = 9, b = 10, c = 12, d = 13;
            dtgActive.Columns[a].Visible = false;            
            dtgActive.Columns[b].Visible = false;
            dtgActive.Columns[c].Visible = false;
            dtgActive.Columns[d].Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
