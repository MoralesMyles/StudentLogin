
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;

namespace Garica0211
{
    public partial class DataInput : Form
    {
        DataGrid f3 = new DataGrid();
        Workbook book = new Workbook();
        public void LoadExcelFile() 
        {           
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\DataSheet.xlsx");
            Worksheet sheet = book.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();
        }
        public string  checkEmpty()
        {   
            
            string error = "";
            foreach(Control c in Controls)
            {
                if(c is TextBox)
                {
                    if(c.Text == "")
                    {
                        error += c.Name + " is empty \n";
                    }
                }
                if (c is CheckBox)
                {
                    if (c.Text == "")
                    {
                        error += c.Name + " is empty \n";
                    }
                }
                if (c is RichTextBox) 
                { 
                    if (c.Text == "")
                    {
                        error += c.Name + " is empty \n";
                    }
                }
                if (c is ComboBox)
                {
                    if (c.Text == "")
                    {
                        error += c.Name + " is empty \n";
                    }
                }

            }
            return error;
        }
        public string checkUnique()
        {
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\DataSheet.xlsx");
            Worksheet sheet = book.Worksheets[0];
            string exist = "";

            int x = 0;

            do
            {
                x++;
                if (sheet.Range[x, 9].Value == txtUsername.Text)
                {
                    exist += "Username already exist";
                }
            }
            while (sheet.Range[x, 9].Value != txtUsername.Text);           
            return exist;
        }
        public DataInput()
        {
            InitializeComponent();
            LoadExcelFile();
        }

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            lblBirthday.Text = Convert.ToString(dtpBirthdate.Value.Month) 
                       + "/" + Convert.ToString(dtpBirthdate.Value.Day)
                       + "/" + Convert.ToString(dtpBirthdate.Value.Year);
            if (DateTime.Now.Month >= dtpBirthdate.Value.Month)
            { 
                    txtAge.Text = Convert.ToString(DateTime.Now.Year - dtpBirthdate.Value.Year);                 
            }
            else
            {
                txtAge.Text = Convert.ToString((DateTime.Now.Year - dtpBirthdate.Value.Year) - 1);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {            
            lblMessage.Text = checkEmpty();
            lblMessage.Text += checkUnique();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\DataSheet.xlsx");
            Worksheet sheet = book.Worksheets[0];

            int row = sheet.Rows.Length + 1;
            //name
            sheet.Range[row, 1].Value = txtName.Text;
            //gender
            if (radMale.Checked)
            { sheet.Range[row, 2].Value = "Male"; }
            else 
            { sheet.Range[row, 2].Value = "Female"; }
            //hobbies
            if (chkBasketball.Checked)

            { if (chkVolleyball.Checked)
                {
                    sheet.Range[row, 3].Value = "Basketball,Volleyball";
                }
                else 
                {
                    sheet.Range[row, 3].Value = "Basketball"; 
                } 
            }
            else if ( chkVolleyball.Checked)
            { 
                sheet.Range[row, 3].Value = "Volleyball"; 
            }
            //Address
            sheet.Range[row, 4].Value = rtxtAddress.Text;
            //Email
            sheet.Range[row, 5].Value = txtEmail.Text;
            //Birthday
            sheet.Range[row, 6].Value = lblBirthday.Text;
            //Age
            sheet.Range[row, 7].Value = txtAge.Text;
            //Username
            sheet.Range[row, 8].Value = rtxtSaying.Text;
            //Password
            sheet.Range[row, 9].Value = txtUsername.Text;
            //Saying
            sheet.Range[row, 10].Value = txtPassword.Text;

            sheet.Range[row, 11].Value = cmbCourse.Text;
            if (lblMessage.Text == "")
            {
                lblMessage.Visible = false;
                book.SaveToFile(@"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\DataSheet.xlsx", ExcelVersion.Version2016);
            } else
            {
                lblMessage.Visible = true;
                return;
            }
                DataTable dt = sheet.ExportDataTable();
            f3.dtgInfoSheet.DataSource = dt;

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            f3.Show();
            btnDisplay.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\DataSheet.xlsx");
            Worksheet sheet = book.Worksheets[0];

            int row = Convert.ToInt16(lblRow.Text) + 2;
            //name
            sheet.Range[row, 1].Value = txtName.Text;
            //gender
            if (radMale.Checked)
            { sheet.Range[row, 2].Value = "Male"; }
            else
            { sheet.Range[row, 2].Value = "Female"; }
            //hobbies
            if (chkBasketball.Checked)

            {
                if (chkVolleyball.Checked)
                {
                    sheet.Range[row, 3].Value = "Basketball,Volleyball";
                }
                else
                {
                    sheet.Range[row, 3].Value = "Basketball";
                }
            }
            else if (chkVolleyball.Checked)
            {
                sheet.Range[row, 3].Value = "Volleyball";
            }
            //Address
            sheet.Range[row, 4].Value = rtxtAddress.Text;
            //Email
            sheet.Range[row, 5].Value = txtEmail.Text;
            //Birthday
            sheet.Range[row, 6].Value = lblBirthday.Text;
            //Age
            sheet.Range[row, 7].Value = txtAge.Text;
            //Username
            sheet.Range[row, 8].Value = rtxtSaying.Text;
            //Password
            sheet.Range[row, 9].Value = txtUsername.Text;
            //Saying
            sheet.Range[row, 10].Value = txtPassword.Text;

            sheet.Range[row, 11].Value = cmbCourse.Text;

            int bol = rdm.Next(0, 1);
            if (bol == 0)
            { sheet.Range[row, 12].Value = "FALSE"; }
            else
            { sheet.Range[row, 12].Value = "TRUE"; }

                book.SaveToFile(@"C:\Users\ACT-STUDENT\source\repos\StudentLogin\ref\DataSheet.xlsx", ExcelVersion.Version2016);
            DataTable dt = sheet.ExportDataTable();
            f3.dtgInfoSheet.DataSource = dt;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (btnDisplay.Enabled == false)
            {
                this.Hide();
                f3.Hide();
            }
            else
            {
                this.Hide();
            }
        }
    }
}
