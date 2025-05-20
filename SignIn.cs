using Spire.Xls;
using Spire.Xls.Core.Spreadsheet.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Garica0211
{
    public partial class SignIn : Form
    {
        DataInput f2 = new DataInput();
        Workbook book = new Workbook();
        DashBoard f3 = new DashBoard();

        public void LoadExcelFile()
        {
           book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\DataSheet.xlsx");
            Worksheet sheet = book.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();
        }

        public SignIn()
        {
            InitializeComponent();
            LoadExcelFile();
            picLogo.Image = Image.FromFile(@"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\SchoolLogo.jpg");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\DataSheet.xlsx");
            Worksheet sheet = book.Worksheets[0];

            int row = sheet.Rows.Length;
            bool log = false;
            

            for (int i = 2; i <= row; i++) 
            {
                if (sheet.Range[i, 9].Value == txtUser.Text && sheet.Range[i, 10].Value == txtPassword.Text)
                {
                    f3.lblName.Text = sheet.Range[i, 1].Value;
                    log = true; break;
                }
                else 
                {
                    log = false;
                }
            }

            if (log == true)
            {
                DialogResult = MessageBox.Show("Successful Login");
                if (DialogResult == DialogResult.OK)
                {
                    for (int i = 2; i <= row; i++)
                    {
                        if (sheet.Range[i, 9].Value == txtUser.Text)
                        {
                            sheet.Range[row, 12].Value = "TRUE";                            
                        }
                    }
                    f3.lblUser.Text = txtUser.Text;
                    MyLog nlog = new MyLog();
                    nlog.InsertLog(txtUser.Text, "User have logged in");

                    book.SaveToFile(@"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\DataSheet.xlsx", ExcelVersion.Version2016);
                    DataTable dt = sheet.ExportDataTable();
                    this.Hide();
                    f3.Show();
                    
                }
            }
            else 
            {
                MessageBox.Show("Invalid Username and Passowrd");
            }           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
