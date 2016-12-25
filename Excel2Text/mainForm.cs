using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office;
using System.Data.OleDb;

namespace Excel2Text
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            dataTable = new System.Data.DataTable("DataTable");
            var lightGrayColor = Color.FromArgb(45, 45, 48);
            var orangeColor = Color.FromArgb(202, 81, 0);
            dataGridViewExcel.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dataGridViewExcel.DefaultCellStyle.BackColor = lightGrayColor;
        }

        private string showMessage
        {
            set
            {
                MessageBox.Show(value);
            }
        }

        string infoTitle;
        private string showInfoMessage
        {
            set
            {
                MessageBox.Show(this,value,infoTitle,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        System.Data.DataTable dataTable;

        private void mainForm_Shown(object sender, EventArgs e)
        {
            using (var dataColumn = new DataColumn("Angle Values"))
            {
                dataTable.Columns.Add(dataColumn);
            }
        }

        private void buttonLoadExcelFile_Click(object sender, EventArgs e)
        {
            try
            {
                var res = openFileDialogExcel.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var fileName = openFileDialogExcel.FileName;

                    const string sheetnNme = "Sheet1";
                    var constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                    fileName +
                                    ";Extended Properties='Excel 8.0;HDR=YES;';";

                    var con = new OleDbConnection(constr);
                    var oconn = new OleDbCommand("Select * From [" + sheetnNme + "$]", con);
                    con.Open();
                    
                    using (var sda = new OleDbDataAdapter(oconn))
                    {
                        var data = new System.Data.DataTable();
                        sda.Fill(data);
                        var a= data.Columns.Count;
                        dataGridViewExcel.DataSource = data;            
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please close the excel file if its already opened somewhere and try again");
            }
        }

        private void buttonExportCSVFile_Click(object sender, EventArgs e)
        {
            var columnData = dataGridViewExcel.GetClipboardContent();
            if (selectedColumn.HasValue)
            {
                var data = columnData.GetData(DataFormats.Text) as string;
                var displayTextBox = new String2CSV(data);
                displayTextBox.Show();                
            }
            else
            showMessage = "Please Select Column First";
        }

        int? selectedColumn=null;
        private void dataGridViewExcel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedColumn =e.ColumnIndex;
            dataGridViewExcel.ClearSelection();
            if (selectedColumn.Value > -1)
            {
                for (int r = 0; r < dataGridViewExcel.RowCount; r++)
                    dataGridViewExcel[selectedColumn.Value, r].Selected = true;
            }
            else
                showMessage = "Please Select one column only";
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            infoTitle = "Help";
            showInfoMessage = "Load excel file using button\n"+
                              "Then select any column by single clicking on any element\n"+
                              "Then click on export data as CSV (comma separated values)file\n"+
                              "Then save that file if required";
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {
            //link to blog/website
            try11();
        }

        private void try11()
        {
        }
        public void try22()
        {
        }
    }
}
