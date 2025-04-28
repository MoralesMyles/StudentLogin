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
    public partial class DataGrid : Form
    {
        //DataInput f2 = (DataInput)Application.OpenForms["Form2"];
      
        public DataGrid()
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
                dtgInfoSheet.DataSource = dt;

                int p = 11;
                dtgInfoSheet.Columns[p].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataInput f2 = (DataInput)Application.OpenForms["DataInput"];
            f2.btnDisplay.Enabled = true;
            f2.btnUpdate.Enabled = false;
            Hide();
        }

        private void dtgInfoSheet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataInput f2 = (DataInput)Application.OpenForms["DataInput"];

            f2.btnUpdate.Enabled = true;

            f2.chkBasketball.Checked = false;
            f2.chkVolleyball.Checked = false;

            int r = dtgInfoSheet.CurrentCell.RowIndex;
            f2.lblRow.Text = r.ToString();

            f2.txtName.Text = dtgInfoSheet.Rows[r].Cells[0].Value.ToString();

            string gender = dtgInfoSheet.Rows[r].Cells[1].Value.ToString();

            if (gender == "Male")
            {
                f2.radMale.Checked = true;
            }
            else if (gender == "Female")
            {
                f2.radFemale.Checked = true;
            }

            string[] h = dtgInfoSheet.Rows[r].Cells[2].Value.ToString().Split(',');

            foreach (string val in h)
            {
                if (val == "Basketball")
                {
                    f2.chkBasketball.Checked = true;
                }
                if (val == "Volleyball")
                {
                    f2.chkVolleyball.Checked = true;
                }
            }

            f2.rtxtAddress.Text = dtgInfoSheet.Rows[r].Cells[3].Value.ToString();
            f2.txtEmail.Text = dtgInfoSheet.Rows[r].Cells[4].Value.ToString();
            f2.dtpBirthdate.Text = dtgInfoSheet.Rows[r].Cells[5].Value.ToString();
            f2.txtUsername.Text = dtgInfoSheet.Rows[r].Cells[8].Value.ToString();
            f2.txtPassword.Text = dtgInfoSheet.Rows[r].Cells[9].Value.ToString();
            f2.rtxtSaying.Text = dtgInfoSheet.Rows[r].Cells[7].Value.ToString();

            


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int r = dtgInfoSheet.Rows.Count;

            dtgInfoSheet.ClearSelection();

            foreach (DataGridViewRow row in dtgInfoSheet.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(txtSearch.Text))
                {
                    row.Selected = true;
                    break;
                }
            }
        }
    }
}
