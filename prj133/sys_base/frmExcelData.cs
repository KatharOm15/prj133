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

namespace prj133.sys_base
{
    public partial class frmExcelData : Form
    {
        public frmExcelData()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        private async void button1_Click(object sender, EventArgs e)
        {

            /*OpenFileDialog fdlg = new OpenFileDialog();

            fdlg.FileName = textBox1.Text;
            fdlg.Filter = "Excel Sheet(*)|*|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;*/
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Sheet(*)|*|All Files(*.*)|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                         using (IExcelDataReader reader =  ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tableCollection = result.Tables;
                            comboBox1.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                 comboBox1.Items.Add(table.TableName);
                            }
                        }
                    }
                }

            }
                

            /*string[] s =File.ReadAllLines(textBox1.Text);
           DataTable dt= new DataTable();
           string[] s1 = s[0].Split(',');
           int a=0;
          for(int i = 0; i < s1.Length; i++)
           {
               dt.Columns.Add(new DataColumn(s1[i]));
               a= dt.Columns.Count;
           }
           for (int i=1;i<s.Length;i++)
           {
               DataRow dr = dt.NewRow();
               string[] temp1 = s[i].Split(',');
               if (!s[i].Contains(','))
               {
                   for (int j = 0; j < a; j++)
                   {

                       dr[j] = temp1[j];
                   }
               }

               else
               {

               }
               dt.Rows.Add(dr);
           }

           dataGridView1.DataSource = dt; */


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[textBox1.Text.ToString()];
            dataGridView1.DataSource= dt;
        }*/
    }
}

