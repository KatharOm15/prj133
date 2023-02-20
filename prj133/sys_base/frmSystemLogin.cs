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
    public partial class frmSystemLogin : Form
    {
        MySqlConnection cnn = new MySqlConnection("user=prj133;password=prj133@automation;server=115.96.168.103;port=3306;database=prj133automation");
        MySqlDataAdapter da;

        DataTable dt=new DataTable();
        public frmSystemLogin()
        {
            InitializeComponent();
        }

        private void btn1_login_Click(object sender, EventArgs e)
        {
            cnn.Open();

            da = new MySqlDataAdapter("select id,name,pwd from usrmaster where name='" + txt1_usrname.Text + "' and pwd='"+txt2_usrpwd.Text + "' and status='1'", cnn);
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0 )
            {
                frmSystemDashboard fsd = new frmSystemDashboard();
                fsd.GetData(dt);
                this.Hide();
                fsd.Show();
                
            }
            else
            {
                
                MessageBox.Show("Invalid User");
                Application.Exit();


            }
       
        }
    }
}
