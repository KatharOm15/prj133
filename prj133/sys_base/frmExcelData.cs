using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;



namespace prj133.sys_base
{
    public partial class frmExcelData : Form
    {
        System.Data.DataTable dtf, temp;
        MySqlDataAdapter da;
        public frmExcelData()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        private async void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text= openFileDialog.FileName;
            }
            dataGridView1.DataSource= ImportExcelToDataTable(textBox1.Text);




        }


        public System.Data.DataTable ImportExcelToDataTable(string filePath)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();

            // Create Excel Application object
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();

            // Open Excel file
            Workbook workbook = application.Workbooks.Open(filePath);

            // Select the first sheet
            Worksheet worksheet = workbook.Sheets[1];

            // Get the range of cells with data
            Microsoft.Office.Interop.Excel.Range range = worksheet.UsedRange;

            // Loop through each row and column, and add the cell value to the DataTable
            for (int row = 1; row <= range.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.NewRow();

                for (int column = 1; column <= range.Columns.Count; column++)
                {
                    if (row == 1)
                    {
                        // Add column headers to the DataTable
                        dataTable.Columns.Add(range.Cells[row, column].Value.ToString());
                    }
                    else
                    {
                        // Add cell values to the DataTable
                        dataRow[column - 1] = range.Cells[row, column].Value.ToString();
                       // MessageBox.Show(range.Cells[row, column].Value.ToString());
                    }
                }

                if (row > 1)
                {
                    dataTable.Rows.Add(dataRow);
                }
            }

            // Close Excel file
            workbook.Close(false, Type.Missing, Type.Missing);
            application.Quit();
            dtf = dataTable;
            return dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection("server=115.96.168.103;port=3306;user=prj133;password=prj133@automation;database=prj133automation");
            cnn.Open();
            da = new MySqlDataAdapter("select aadhar_no from candidatemaster", cnn);
            temp = new System.Data.DataTable();
            da.Fill(temp); 
            StringBuilder str= new StringBuilder();
            for(int i=0; i<temp.Rows.Count;i++)
            {
                str.Append(',');
                str.Append(temp.Rows[i][0].ToString());
            }
            string str2=str.ToString();
            MessageBox.Show(str2);
            for (int i = 1; i < dtf.Rows.Count; i++)
            {
                //MessageBox.Show(dtf.Rows[i][10].ToString()+" : "+i);
                
                //MessageBox.Show(dtf.Rows[i][10].ToString()+" : "+i);


                if (!str2.Contains(dtf.Rows[i][9].ToString()))
                {

                    MessageBox.Show(dtf.Rows[i][11].ToString()+":"+i);
                    MySqlCommand cmd = new MySqlCommand("insert into candidatemaster (name,location,self_mobile,gender,caste,scholership,institute,stream,email,aadhar_no) values ('" + dtf.Rows[i][2].ToString() + "','" + dtf.Rows[i][1].ToString() + "','" + dtf.Rows[i][3].ToString() + "','" + dtf.Rows[i][6].ToString() + "','" + dtf.Rows[i][7].ToString() + "','" + dtf.Rows[i][8].ToString() + "','" + dtf.Rows[i][11].ToString() + "','" + dtf.Rows[i][10].ToString() + "','" + dtf.Rows[i][4].ToString() + "','" + dtf.Rows[i][9].ToString() + "')", cnn);
                    cmd.ExecuteNonQuery();

                }

            }
            MessageBox.Show("fkjvsfkgjdsf");
            cnn.Close();
            
            
        }
    }
}

