namespace prj133.sys_base
{
    partial class frmUpdateDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_scholarship = new System.Windows.Forms.ComboBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.cmb_religion = new System.Windows.Forms.ComboBox();
            this.cmb_location = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_scholarship = new System.Windows.Forms.Label();
            this.txt_aadhar = new System.Windows.Forms.TextBox();
            this.lbl_aadhar_no = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.txt_caste = new System.Windows.Forms.TextBox();
            this.lbl_caste = new System.Windows.Forms.Label();
            this.lbl_religion = new System.Windows.Forms.Label();
            this.txt_stream = new System.Windows.Forms.TextBox();
            this.lbl_stream = new System.Windows.Forms.Label();
            this.txt_institude = new System.Windows.Forms.TextBox();
            this.lbl_institute = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.txt_self_whatsapp = new System.Windows.Forms.TextBox();
            this.lbl_self_whatsapp = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.txt_self_mob = new System.Windows.Forms.TextBox();
            this.lbl_self_mob = new System.Windows.Forms.Label();
            this.txt_mother_name = new System.Windows.Forms.TextBox();
            this.lbl_mother_name = new System.Windows.Forms.Label();
            this.txt_father_name = new System.Windows.Forms.TextBox();
            this.lbl_father_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_scholarship
            // 
            this.cmb_scholarship.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_scholarship.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_scholarship.FormattingEnabled = true;
            this.cmb_scholarship.Items.AddRange(new object[] {
            "Yes ",
            "No"});
            this.cmb_scholarship.Location = new System.Drawing.Point(957, 324);
            this.cmb_scholarship.Name = "cmb_scholarship";
            this.cmb_scholarship.Size = new System.Drawing.Size(284, 36);
            this.cmb_scholarship.TabIndex = 79;
            // 
            // cmb_category
            // 
            this.cmb_category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_category.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Items.AddRange(new object[] {
            "OBC",
            "OPEN",
            "SC ",
            "VJ/NT",
            "ST",
            "Other"});
            this.cmb_category.Location = new System.Drawing.Point(957, 209);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(284, 36);
            this.cmb_category.TabIndex = 78;
            // 
            // cmb_religion
            // 
            this.cmb_religion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_religion.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_religion.FormattingEnabled = true;
            this.cmb_religion.Items.AddRange(new object[] {
            "Hinduism",
            "Cristianity",
            "Islam",
            "Jainism",
            "Bhuddism"});
            this.cmb_religion.Location = new System.Drawing.Point(957, 114);
            this.cmb_religion.Name = "cmb_religion";
            this.cmb_religion.Size = new System.Drawing.Size(284, 36);
            this.cmb_religion.TabIndex = 77;
            // 
            // cmb_location
            // 
            this.cmb_location.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_location.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_location.FormattingEnabled = true;
            this.cmb_location.Items.AddRange(new object[] {
            "Sangli",
            "Satara",
            "Solapur",
            "Kolhapur",
            "Pune",
            "Akola",
            "Amravati",
            "Buldhana",
            "Yavatmal",
            "Washim",
            "Aurangabad",
            "Beed",
            "Jalna",
            "Osmanabad",
            "Nanded",
            "Latur",
            "Parbhani",
            "Hingoli",
            "Bhandara",
            "Chandrapur",
            "Gadchiroli",
            "Gondia",
            "Nagpur",
            "Wardha",
            "Dhule",
            "Jalgaon",
            "Nandurbar",
            "Nashik",
            "Ahmednagar",
            "Mumbai City District",
            "Mumbai Suburban District",
            "Thane",
            "Palghar",
            "Raigad",
            "Ratnagiri",
            "Sindhudurg",
            "Other"});
            this.cmb_location.Location = new System.Drawing.Point(360, 216);
            this.cmb_location.Name = "cmb_location";
            this.cmb_location.Size = new System.Drawing.Size(284, 36);
            this.cmb_location.TabIndex = 76;
            this.cmb_location.Text = "Select Your Location";
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_submit.BackColor = System.Drawing.Color.Navy;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_submit.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(573, 499);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(213, 77);
            this.btn_submit.TabIndex = 74;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.Location = new System.Drawing.Point(957, 386);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(284, 35);
            this.txt_email.TabIndex = 73;
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_email.Location = new System.Drawing.Point(699, 392);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(82, 28);
            this.lbl_email.TabIndex = 72;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_scholarship
            // 
            this.lbl_scholarship.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_scholarship.AutoSize = true;
            this.lbl_scholarship.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_scholarship.ForeColor = System.Drawing.Color.Black;
            this.lbl_scholarship.Location = new System.Drawing.Point(697, 321);
            this.lbl_scholarship.Name = "lbl_scholarship";
            this.lbl_scholarship.Size = new System.Drawing.Size(138, 28);
            this.lbl_scholarship.TabIndex = 71;
            this.lbl_scholarship.Text = "Scholarship";
            // 
            // txt_aadhar
            // 
            this.txt_aadhar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_aadhar.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_aadhar.ForeColor = System.Drawing.Color.Black;
            this.txt_aadhar.Location = new System.Drawing.Point(957, 261);
            this.txt_aadhar.Name = "txt_aadhar";
            this.txt_aadhar.Size = new System.Drawing.Size(284, 35);
            this.txt_aadhar.TabIndex = 70;
            // 
            // lbl_aadhar_no
            // 
            this.lbl_aadhar_no.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_aadhar_no.AutoSize = true;
            this.lbl_aadhar_no.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_aadhar_no.ForeColor = System.Drawing.Color.Black;
            this.lbl_aadhar_no.Location = new System.Drawing.Point(699, 261);
            this.lbl_aadhar_no.Name = "lbl_aadhar_no";
            this.lbl_aadhar_no.Size = new System.Drawing.Size(185, 28);
            this.lbl_aadhar_no.TabIndex = 69;
            this.lbl_aadhar_no.Text = "Aadhar Number";
            // 
            // lbl_category
            // 
            this.lbl_category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_category.ForeColor = System.Drawing.Color.Black;
            this.lbl_category.Location = new System.Drawing.Point(699, 206);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(109, 28);
            this.lbl_category.TabIndex = 68;
            this.lbl_category.Text = "Category";
            // 
            // txt_caste
            // 
            this.txt_caste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_caste.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_caste.Location = new System.Drawing.Point(957, 161);
            this.txt_caste.Name = "txt_caste";
            this.txt_caste.Size = new System.Drawing.Size(284, 35);
            this.txt_caste.TabIndex = 67;
            // 
            // lbl_caste
            // 
            this.lbl_caste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_caste.AutoSize = true;
            this.lbl_caste.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_caste.Location = new System.Drawing.Point(697, 165);
            this.lbl_caste.Name = "lbl_caste";
            this.lbl_caste.Size = new System.Drawing.Size(71, 28);
            this.lbl_caste.TabIndex = 66;
            this.lbl_caste.Text = "Caste";
            // 
            // lbl_religion
            // 
            this.lbl_religion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_religion.AutoSize = true;
            this.lbl_religion.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_religion.Location = new System.Drawing.Point(699, 113);
            this.lbl_religion.Name = "lbl_religion";
            this.lbl_religion.Size = new System.Drawing.Size(105, 28);
            this.lbl_religion.TabIndex = 65;
            this.lbl_religion.Text = "Religion";
            // 
            // txt_stream
            // 
            this.txt_stream.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_stream.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_stream.ForeColor = System.Drawing.Color.Black;
            this.txt_stream.Location = new System.Drawing.Point(957, 57);
            this.txt_stream.Name = "txt_stream";
            this.txt_stream.Size = new System.Drawing.Size(284, 35);
            this.txt_stream.TabIndex = 64;
            // 
            // lbl_stream
            // 
            this.lbl_stream.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_stream.AutoSize = true;
            this.lbl_stream.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_stream.Location = new System.Drawing.Point(699, 57);
            this.lbl_stream.Name = "lbl_stream";
            this.lbl_stream.Size = new System.Drawing.Size(87, 28);
            this.lbl_stream.TabIndex = 63;
            this.lbl_stream.Text = "Stream";
            // 
            // txt_institude
            // 
            this.txt_institude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_institude.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_institude.ForeColor = System.Drawing.Color.Black;
            this.txt_institude.Location = new System.Drawing.Point(957, 8);
            this.txt_institude.Name = "txt_institude";
            this.txt_institude.Size = new System.Drawing.Size(284, 35);
            this.txt_institude.TabIndex = 62;
            // 
            // lbl_institute
            // 
            this.lbl_institute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_institute.AutoSize = true;
            this.lbl_institute.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_institute.ForeColor = System.Drawing.Color.Black;
            this.lbl_institute.Location = new System.Drawing.Point(699, 12);
            this.lbl_institute.Name = "lbl_institute";
            this.lbl_institute.Size = new System.Drawing.Size(103, 28);
            this.lbl_institute.TabIndex = 61;
            this.lbl_institute.Text = "Institute";
            // 
            // lbl_dob
            // 
            this.lbl_dob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dob.ForeColor = System.Drawing.Color.Black;
            this.lbl_dob.Location = new System.Drawing.Point(699, -40);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(157, 28);
            this.lbl_dob.TabIndex = 60;
            this.lbl_dob.Text = "Date Of Birth";
            // 
            // lbl_gender
            // 
            this.lbl_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_gender.ForeColor = System.Drawing.Color.Black;
            this.lbl_gender.Location = new System.Drawing.Point(144, 398);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(92, 28);
            this.lbl_gender.TabIndex = 59;
            this.lbl_gender.Text = "Gender";
            // 
            // txt_self_whatsapp
            // 
            this.txt_self_whatsapp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_self_whatsapp.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_self_whatsapp.ForeColor = System.Drawing.Color.Black;
            this.txt_self_whatsapp.Location = new System.Drawing.Point(360, 333);
            this.txt_self_whatsapp.Name = "txt_self_whatsapp";
            this.txt_self_whatsapp.Size = new System.Drawing.Size(284, 35);
            this.txt_self_whatsapp.TabIndex = 58;
            // 
            // lbl_self_whatsapp
            // 
            this.lbl_self_whatsapp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_self_whatsapp.AutoSize = true;
            this.lbl_self_whatsapp.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_self_whatsapp.ForeColor = System.Drawing.Color.Black;
            this.lbl_self_whatsapp.Location = new System.Drawing.Point(142, 337);
            this.lbl_self_whatsapp.Name = "lbl_self_whatsapp";
            this.lbl_self_whatsapp.Size = new System.Drawing.Size(174, 28);
            this.lbl_self_whatsapp.TabIndex = 57;
            this.lbl_self_whatsapp.Text = "Self WhatsApp";
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_address.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_address.ForeColor = System.Drawing.Color.Black;
            this.txt_address.Location = new System.Drawing.Point(360, 113);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(284, 65);
            this.txt_address.TabIndex = 56;
            // 
            // lbl_address
            // 
            this.lbl_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_address.ForeColor = System.Drawing.Color.Black;
            this.lbl_address.Location = new System.Drawing.Point(144, 129);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(99, 28);
            this.lbl_address.TabIndex = 55;
            this.lbl_address.Text = "Address";
            // 
            // lbl_location
            // 
            this.lbl_location.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_location.AutoSize = true;
            this.lbl_location.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_location.ForeColor = System.Drawing.Color.Black;
            this.lbl_location.Location = new System.Drawing.Point(142, 213);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(104, 28);
            this.lbl_location.TabIndex = 54;
            this.lbl_location.Text = "Location";
            // 
            // txt_self_mob
            // 
            this.txt_self_mob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_self_mob.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_self_mob.ForeColor = System.Drawing.Color.Black;
            this.txt_self_mob.Location = new System.Drawing.Point(360, 266);
            this.txt_self_mob.Name = "txt_self_mob";
            this.txt_self_mob.Size = new System.Drawing.Size(284, 35);
            this.txt_self_mob.TabIndex = 53;
            // 
            // lbl_self_mob
            // 
            this.lbl_self_mob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_self_mob.AutoSize = true;
            this.lbl_self_mob.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_self_mob.ForeColor = System.Drawing.Color.Black;
            this.lbl_self_mob.Location = new System.Drawing.Point(142, 270);
            this.lbl_self_mob.Name = "lbl_self_mob";
            this.lbl_self_mob.Size = new System.Drawing.Size(139, 28);
            this.lbl_self_mob.TabIndex = 52;
            this.lbl_self_mob.Text = "Self Mobile";
            // 
            // txt_mother_name
            // 
            this.txt_mother_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_mother_name.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_mother_name.ForeColor = System.Drawing.Color.Black;
            this.txt_mother_name.Location = new System.Drawing.Point(360, 58);
            this.txt_mother_name.Name = "txt_mother_name";
            this.txt_mother_name.Size = new System.Drawing.Size(284, 35);
            this.txt_mother_name.TabIndex = 51;
            // 
            // lbl_mother_name
            // 
            this.lbl_mother_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_mother_name.AutoSize = true;
            this.lbl_mother_name.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_mother_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_mother_name.Location = new System.Drawing.Point(142, 62);
            this.lbl_mother_name.Name = "lbl_mother_name";
            this.lbl_mother_name.Size = new System.Drawing.Size(160, 28);
            this.lbl_mother_name.TabIndex = 50;
            this.lbl_mother_name.Text = "Mother Name";
            // 
            // txt_father_name
            // 
            this.txt_father_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_father_name.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_father_name.ForeColor = System.Drawing.Color.Black;
            this.txt_father_name.Location = new System.Drawing.Point(360, 2);
            this.txt_father_name.Name = "txt_father_name";
            this.txt_father_name.Size = new System.Drawing.Size(284, 35);
            this.txt_father_name.TabIndex = 49;
            // 
            // lbl_father_name
            // 
            this.lbl_father_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_father_name.AutoSize = true;
            this.lbl_father_name.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_father_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_father_name.Location = new System.Drawing.Point(142, 12);
            this.lbl_father_name.Name = "lbl_father_name";
            this.lbl_father_name.Size = new System.Drawing.Size(149, 28);
            this.lbl_father_name.TabIndex = 48;
            this.lbl_father_name.Text = "Father Name";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(360, -44);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(284, 35);
            this.txt_name.TabIndex = 47;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(142, -40);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(75, 28);
            this.lbl_name.TabIndex = 46;
            this.lbl_name.Text = "Name";
            // 
            // rb_male
            // 
            this.rb_male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_male.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_male.Location = new System.Drawing.Point(360, 398);
            this.rb_male.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(119, 32);
            this.rb_male.TabIndex = 75;
            this.rb_male.Text = "Male";
            // 
            // rb_female
            // 
            this.rb_female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_female.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_female.Location = new System.Drawing.Point(505, 394);
            this.rb_female.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(139, 32);
            this.rb_female.TabIndex = 45;
            this.rb_female.Text = "Female";
            // 
            // dtp_dob
            // 
            this.dtp_dob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_dob.CustomFormat = "yyyy-MM-dd";
            this.dtp_dob.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dob.Location = new System.Drawing.Point(957, -45);
            this.dtp_dob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(284, 35);
            this.dtp_dob.TabIndex = 44;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 80;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUpdateDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_scholarship);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.cmb_religion);
            this.Controls.Add(this.cmb_location);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_scholarship);
            this.Controls.Add(this.txt_aadhar);
            this.Controls.Add(this.lbl_aadhar_no);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.txt_caste);
            this.Controls.Add(this.lbl_caste);
            this.Controls.Add(this.lbl_religion);
            this.Controls.Add(this.txt_stream);
            this.Controls.Add(this.lbl_stream);
            this.Controls.Add(this.txt_institude);
            this.Controls.Add(this.lbl_institute);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.txt_self_whatsapp);
            this.Controls.Add(this.lbl_self_whatsapp);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.txt_self_mob);
            this.Controls.Add(this.lbl_self_mob);
            this.Controls.Add(this.txt_mother_name);
            this.Controls.Add(this.lbl_mother_name);
            this.Controls.Add(this.txt_father_name);
            this.Controls.Add(this.lbl_father_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.dtp_dob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateDetails";
            this.Text = "frmUpdateDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_scholarship;
        private ComboBox cmb_category;
        private ComboBox cmb_religion;
        private ComboBox cmb_location;
        private Button btn_submit;
        private TextBox txt_email;
        private Label lbl_email;
        private Label lbl_scholarship;
        private TextBox txt_aadhar;
        private Label lbl_aadhar_no;
        private Label lbl_category;
        private TextBox txt_caste;
        private Label lbl_caste;
        private Label lbl_religion;
        private TextBox txt_stream;
        private Label lbl_stream;
        private TextBox txt_institude;
        private Label lbl_institute;
        private Label lbl_dob;
        private Label lbl_gender;
        private TextBox txt_self_whatsapp;
        private Label lbl_self_whatsapp;
        private TextBox txt_address;
        private Label lbl_address;
        private Label lbl_location;
        private TextBox txt_self_mob;
        private Label lbl_self_mob;
        private TextBox txt_mother_name;
        private Label lbl_mother_name;
        private TextBox txt_father_name;
        private Label lbl_father_name;
        private TextBox txt_name;
        private Label lbl_name;
        private RadioButton rb_male;
        private RadioButton rb_female;
        private DateTimePicker dtp_dob;
        private OpenFileDialog openFileDialog1;
        private Button button1;
    }
}