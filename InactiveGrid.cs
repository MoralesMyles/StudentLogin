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
    public partial class InactiveGrid: Form
    {
        DashBoard db = new DashBoard();
        public InactiveGrid()
        {
            InitializeComponent();
            LoadExcelFile();
        }
        public void LoadExcelFile()
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\DataSheet.xlsx");
            Worksheet sheet = book.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();
            dtgActive.DataSource = dt;
            dt.DefaultView.RowFilter = "Active = FALSE";
            int a = 8, b = 9, c = 11, d = 12;
            dtgActive.Columns[a].Visible = false;
            dtgActive.Columns[b].Visible = false;
            dtgActive.Columns[c].Visible = false;
            dtgActive.Columns[d].Visible = false;
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

        private void btnInactive_Click(object sender, EventArgs e)
        {
            MyLog nlog = new MyLog();
            nlog.InsertLog(db.lblUser.Text, "Set a student to Inactive");
        }
    }
}
