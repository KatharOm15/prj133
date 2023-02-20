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
namespace prj133
{
    public partial class frmNewAdmission : Form
    {
        MySqlConnection conn=new MySqlConnection("server=115.96.168.103;port=3306;user=prj133;password=prj133@automation;database=prj133automation");
        MySqlCommand cmd;
        string val;
        public frmNewAdmission()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            { 
            conn.Open();
            cmd = new MySqlCommand("insert into candidatemaster (name,father_name,mother_name,addr,location,self_mobile,self_whatsapp,gender,dob,institute,stream,religion,caste,category,aadhar_no,scholership,email) values ('" + txt_name.Text + "','" + txt_father_name.Text + "','" + txt_mother_name.Text + "','" + txt_address.Text + "','" + cmb_location.Text + "','" + txt_self_mob.Text + "','" + txt_self_whatsapp.Text + "','" + val + "','" + dtp_dob.Text + "','" + txt_institude.Text + "','" + txt_stream.Text + "','" + cmb_religion.Text + "','" + txt_caste.Text + "','" + cmb_category.Text + "','" + txt_aadhar.Text + "','" + cmb_scholarship.Text + "','" + txt_email.Text + "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully");
            conn.Close();
            }
            catch(Exception ex) { 
                MessageBox.Show("Data Is Not Inserted");
            }

        }

        private void frmNewAdmission_Load(object sender, EventArgs e)
        {

        }

        private void rb_male_CheckedChanged(object sender, EventArgs e)
        {
            val = "male";
        }

        private void rb_female_CheckedChanged(object sender, EventArgs e)
        {
            val = "female";
        }
    }
}
