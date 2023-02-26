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

namespace prj133.sys_base
{
    public partial class frmStudentList : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=115.96.168.103;port=3306;user=prj133;password=prj133@automation;database=prj133automation");
        MySqlDataAdapter da;
        DataTable dt = new DataTable();
        public frmStudentList()
        {
            InitializeComponent();
        }

        private void frmStudentList_Load(object sender, EventArgs e)
        {
            cnn.Open();
            da = new MySqlDataAdapter("Select name,self_mobile,gender,dob,email,reg_date from candidatemaster", cnn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();

        }

        private void lbl_update_details_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmUpdateDetails().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
