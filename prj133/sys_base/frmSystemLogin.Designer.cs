namespace prj133.sys_base
{
    partial class frmSystemLogin
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
            this.btn1_login = new System.Windows.Forms.Button();
            this.txt1_usrname = new System.Windows.Forms.TextBox();
            this.txt2_usrpwd = new System.Windows.Forms.TextBox();
            this.lbl1_usrname = new System.Windows.Forms.Label();
            this.lbl2_usrpwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1_login
            // 
            this.btn1_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1_login.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1_login.Location = new System.Drawing.Point(260, 344);
            this.btn1_login.Name = "btn1_login";
            this.btn1_login.Size = new System.Drawing.Size(207, 65);
            this.btn1_login.TabIndex = 0;
            this.btn1_login.Text = "Login";
            this.btn1_login.UseVisualStyleBackColor = true;
            this.btn1_login.Click += new System.EventHandler(this.btn1_login_Click);
            // 
            // txt1_usrname
            // 
            this.txt1_usrname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt1_usrname.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt1_usrname.Location = new System.Drawing.Point(426, 107);
            this.txt1_usrname.Name = "txt1_usrname";
            this.txt1_usrname.Size = new System.Drawing.Size(231, 35);
            this.txt1_usrname.TabIndex = 1;
            // 
            // txt2_usrpwd
            // 
            this.txt2_usrpwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt2_usrpwd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt2_usrpwd.Location = new System.Drawing.Point(426, 213);
            this.txt2_usrpwd.Name = "txt2_usrpwd";
            this.txt2_usrpwd.PasswordChar = '●';
            this.txt2_usrpwd.Size = new System.Drawing.Size(231, 35);
            this.txt2_usrpwd.TabIndex = 2;
            // 
            // lbl1_usrname
            // 
            this.lbl1_usrname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1_usrname.AutoSize = true;
            this.lbl1_usrname.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1_usrname.Location = new System.Drawing.Point(156, 107);
            this.lbl1_usrname.Name = "lbl1_usrname";
            this.lbl1_usrname.Size = new System.Drawing.Size(152, 28);
            this.lbl1_usrname.TabIndex = 3;
            this.lbl1_usrname.Text = "User Name";
            // 
            // lbl2_usrpwd
            // 
            this.lbl2_usrpwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2_usrpwd.AutoSize = true;
            this.lbl2_usrpwd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2_usrpwd.Location = new System.Drawing.Point(156, 213);
            this.lbl2_usrpwd.Name = "lbl2_usrpwd";
            this.lbl2_usrpwd.Size = new System.Drawing.Size(138, 28);
            this.lbl2_usrpwd.TabIndex = 4;
            this.lbl2_usrpwd.Text = "Password";
            // 
            // frmSystemLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 505);
            this.Controls.Add(this.lbl2_usrpwd);
            this.Controls.Add(this.lbl1_usrname);
            this.Controls.Add(this.txt2_usrpwd);
            this.Controls.Add(this.txt1_usrname);
            this.Controls.Add(this.btn1_login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSystemLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSystemLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn1_login;
        private TextBox txt1_usrname;
        private TextBox txt2_usrpwd;
        private Label lbl1_usrname;
        private Label lbl2_usrpwd;
    }
}