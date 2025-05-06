using Microsoft.SqlServer.Server;
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
    public partial class DashBoard: Form
    {
        SignIn f1 = (SignIn)Application.OpenForms["SignIn"];
        DataInput f2 = new DataInput();
        public Workbook book = new Workbook();
        public void LoadExcelFile()
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Garica0303\ref\DataSheet.xlsx");
            Worksheet sheet = book.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();
        }
        public DashBoard()
        {
            InitializeComponent();
            picProfile.Image = Image.FromFile(@"https://png.pngtree.com//png-vector//20190223//ourmid//pngtree-student-glyph-black-icon-png-image_691145.jpg");
            LoadExcelFile();
            string Date;
            Date = ($"{Convert.ToString(DateTime.Now.Month)}/{Convert.ToString(DateTime.Now.Day)}/{Convert.ToString(DateTime.Now.Year)}");
            lblDate.Text = Date;

            lblMaleAmount.Text = showcount(2, "Male").ToString();
            lblFemaleAmount.Text = showcount(2, "Female").ToString();
            lblBasketballCount.Text = showcount(3, "Basketball").ToString();
            lblVolleyballAmount.Text = showcount(3, "Volleyball").ToString();
            lblHybridCount.Text = showcount(3, "Basketball,Volleyball").ToString();
            lblBasketballCount.Text = Convert.ToString(Convert.ToInt16(lblBasketballCount.Text) + Convert.ToInt16(lblHybridCount.Text));
            lblVolleyballAmount.Text = Convert.ToString(Convert.ToInt16(lblVolleyballAmount.Text) + Convert.ToInt16(lblHybridCount.Text));
            lblBSITCount.Text = showcount(11, "BSIT").ToString();
            lblBScSCount.Text = showcount(11, "BScS").ToString();
            lblBEEDCount.Text = showcount(11, "BEED").ToString();
            lblBSCECount.Text = showcount(11, "BSCE").ToString();
            lblActiveAmount.Text = showcount(12, "TRUE").ToString();
            lblInactiveAmount.Text = showcount(12, "FALSE").ToString();
        }
        public int showcount(int c, string val)
        {
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Garica0303\ref\DataSheet.xlsx");
            Worksheet sheet = book.Worksheets[0];
            int row = sheet.Rows.Length;
            int counter = 0;
            for(int i = 2; i<= row;i++)
            { 
                if (sheet.Range[i,c].Value == val)
                {
                    counter++;
                }
            }
            return counter;
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {

        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            {
                if (f2.btnDisplay.Enabled == false)
                { f2.btnDisplay.Enabled = true; }
                f2.ShowDialog();
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Garica0303\ref\DataSheet.xlsx");
            Worksheet sheet = book.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();

            int row = sheet.Rows.Length;
            for (int i = 2; i <= row; i++)
            {
                if (sheet.Range[i, 1].Value == lblName.Text)
                {
                    sheet.Range[row, 12].Value = "FALSE";
                    break;
                }
            }
            book.SaveToFile(@"C:\Users\ACT-STUDENT\Desktop\Garica0303\ref\DataSheet.xlsx", ExcelVersion.Version2016);

            SignIn f1 = new SignIn();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
 
        private void btnExit_Click(object sender, EventArgs e)        
        {
           Application.Exit();
        }

        //Need to code this
        private void btnActiveStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActiveGrid f3 = new ActiveGrid();
            f3.ShowDialog();
            
        }

        private void Logs_Click(object sender, EventArgs e)
        {

        }

        private void btnInactiveStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            InactiveGrid f4 = new InactiveGrid();
            f4.ShowDialog();


        }
    }
}
