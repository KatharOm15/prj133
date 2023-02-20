using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj133.sys_base
{
    public partial class frmSystemDashboard : Form
    {
        DataTable dt = new DataTable();

        public void GetData(DataTable st) 
        {
            dt = st;
             /*txt1_id.Text = dt.Rows[0].ItemArray[0].ToString();
            txt2_usr_name.Text = dt.Rows[0].ItemArray[1].ToString();
            txt3_usr_role.Text= dt.Rows[0].ItemArray[2].ToString();*/
        }
        
        public frmSystemDashboard()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewAdmission na = new frmNewAdmission();
            this.Hide();
            na.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentList fst=new frmStudentList();
            fst.Show();
        }

        private void pnl_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_stud_profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmNewAdmission().Show();
        }
    }
}
