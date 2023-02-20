namespace prj133.sys_base
{
    partial class frmSystemDashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_trainer_profile = new System.Windows.Forms.Button();
            this.btn_meeting = new System.Windows.Forms.Button();
            this.btn_stud_profile = new System.Windows.Forms.Button();
            this.btn_batch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_menu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(183, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(614, 522);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 83);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 21);
            this.panel2.TabIndex = 1;
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnl_menu.Controls.Add(this.btn_settings);
            this.pnl_menu.Controls.Add(this.btn_report);
            this.pnl_menu.Controls.Add(this.btn_trainer_profile);
            this.pnl_menu.Controls.Add(this.btn_meeting);
            this.pnl_menu.Controls.Add(this.btn_stud_profile);
            this.pnl_menu.Controls.Add(this.btn_batch);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(180, 528);
            this.pnl_menu.TabIndex = 0;
            this.pnl_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_menu_Paint);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_settings.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.btn_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_settings.Location = new System.Drawing.Point(0, 353);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(180, 70);
            this.btn_settings.TabIndex = 5;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = false;
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_report.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.btn_report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_report.Location = new System.Drawing.Point(0, 283);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(180, 70);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = false;
            // 
            // btn_trainer_profile
            // 
            this.btn_trainer_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_trainer_profile.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.btn_trainer_profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_trainer_profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_trainer_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trainer_profile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_trainer_profile.Location = new System.Drawing.Point(0, 213);
            this.btn_trainer_profile.Name = "btn_trainer_profile";
            this.btn_trainer_profile.Size = new System.Drawing.Size(180, 70);
            this.btn_trainer_profile.TabIndex = 3;
            this.btn_trainer_profile.Text = "Trainer Profile";
            this.btn_trainer_profile.UseVisualStyleBackColor = false;
            // 
            // btn_meeting
            // 
            this.btn_meeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_meeting.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.btn_meeting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_meeting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_meeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_meeting.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_meeting.Location = new System.Drawing.Point(0, 143);
            this.btn_meeting.Name = "btn_meeting";
            this.btn_meeting.Size = new System.Drawing.Size(180, 70);
            this.btn_meeting.TabIndex = 2;
            this.btn_meeting.Text = "Meeting";
            this.btn_meeting.UseVisualStyleBackColor = false;
            // 
            // btn_stud_profile
            // 
            this.btn_stud_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_stud_profile.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.btn_stud_profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_stud_profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_stud_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stud_profile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stud_profile.Location = new System.Drawing.Point(0, 73);
            this.btn_stud_profile.Name = "btn_stud_profile";
            this.btn_stud_profile.Size = new System.Drawing.Size(180, 70);
            this.btn_stud_profile.TabIndex = 1;
            this.btn_stud_profile.Text = "Student Profile";
            this.btn_stud_profile.UseVisualStyleBackColor = false;
            this.btn_stud_profile.Click += new System.EventHandler(this.btn_stud_profile_Click);
            // 
            // btn_batch
            // 
            this.btn_batch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_batch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.btn_batch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_batch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_batch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_batch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_batch.Location = new System.Drawing.Point(0, 3);
            this.btn_batch.Name = "btn_batch";
            this.btn_batch.Size = new System.Drawing.Size(180, 70);
            this.btn_batch.TabIndex = 0;
            this.btn_batch.Text = "Batches";
            this.btn_batch.UseVisualStyleBackColor = false;
            this.btn_batch.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSystemDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSystemDashboard";
            this.Text = "frmSystemDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnl_menu;
        private Button btn_report;
        private Button btn_trainer_profile;
        private Button btn_meeting;
        private Button btn_stud_profile;
        private Button btn_batch;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Button btn_settings;
        private Panel panel2;
    }
}