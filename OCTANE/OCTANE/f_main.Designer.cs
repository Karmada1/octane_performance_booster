namespace OCTANE
{
    partial class f_main
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
            this.p_header = new System.Windows.Forms.Panel();
            this.t_exit = new System.Windows.Forms.Label();
            this.t_min = new System.Windows.Forms.Label();
            this.t_form_name = new System.Windows.Forms.Label();
            this.p_body = new System.Windows.Forms.Panel();
            this.t_credits = new System.Windows.Forms.Label();
            this.gb_gaming = new System.Windows.Forms.GroupBox();
            this.b_gaming_throttle = new System.Windows.Forms.Button();
            this.b_enable_cortana = new System.Windows.Forms.Button();
            this.gb_general = new System.Windows.Forms.GroupBox();
            this.b_general_advanced = new System.Windows.Forms.Button();
            this.b_general_bloat = new System.Windows.Forms.Button();
            this.gb_disabled = new System.Windows.Forms.GroupBox();
            this.cb_disable_services = new System.Windows.Forms.CheckBox();
            this.cb_disable_reboot = new System.Windows.Forms.CheckBox();
            this.cb_disable_cortana = new System.Windows.Forms.CheckBox();
            this.cb_disable_windows_updates = new System.Windows.Forms.CheckBox();
            this.b_disable_apply = new System.Windows.Forms.Button();
            this.cb_disable_app_updates = new System.Windows.Forms.CheckBox();
            this.b_reboot = new System.Windows.Forms.Button();
            this.p_header.SuspendLayout();
            this.p_body.SuspendLayout();
            this.gb_gaming.SuspendLayout();
            this.gb_general.SuspendLayout();
            this.gb_disabled.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_header
            // 
            this.p_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.p_header.Controls.Add(this.t_exit);
            this.p_header.Controls.Add(this.t_min);
            this.p_header.Controls.Add(this.t_form_name);
            this.p_header.Location = new System.Drawing.Point(1, 2);
            this.p_header.Name = "p_header";
            this.p_header.Size = new System.Drawing.Size(370, 43);
            this.p_header.TabIndex = 0;
            // 
            // t_exit
            // 
            this.t_exit.AutoSize = true;
            this.t_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.t_exit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_exit.Location = new System.Drawing.Point(332, 8);
            this.t_exit.Name = "t_exit";
            this.t_exit.Size = new System.Drawing.Size(26, 25);
            this.t_exit.TabIndex = 2;
            this.t_exit.Text = "X";
            this.t_exit.Click += new System.EventHandler(this.t_exit_Click);
            // 
            // t_min
            // 
            this.t_min.AutoSize = true;
            this.t_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.t_min.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_min.Location = new System.Drawing.Point(9, -2);
            this.t_min.Name = "t_min";
            this.t_min.Size = new System.Drawing.Size(33, 35);
            this.t_min.TabIndex = 1;
            this.t_min.Text = "_";
            this.t_min.Click += new System.EventHandler(this.t_min_Click);
            // 
            // t_form_name
            // 
            this.t_form_name.AutoSize = true;
            this.t_form_name.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_form_name.Location = new System.Drawing.Point(93, 10);
            this.t_form_name.Name = "t_form_name";
            this.t_form_name.Size = new System.Drawing.Size(189, 23);
            this.t_form_name.TabIndex = 0;
            this.t_form_name.Text = "OCTANE BOOSTER";
            // 
            // p_body
            // 
            this.p_body.Controls.Add(this.t_credits);
            this.p_body.Controls.Add(this.gb_gaming);
            this.p_body.Controls.Add(this.b_enable_cortana);
            this.p_body.Controls.Add(this.gb_general);
            this.p_body.Controls.Add(this.gb_disabled);
            this.p_body.Controls.Add(this.b_reboot);
            this.p_body.Location = new System.Drawing.Point(1, 51);
            this.p_body.Name = "p_body";
            this.p_body.Size = new System.Drawing.Size(370, 384);
            this.p_body.TabIndex = 1;
            // 
            // t_credits
            // 
            this.t_credits.AutoSize = true;
            this.t_credits.Location = new System.Drawing.Point(65, 2);
            this.t_credits.Name = "t_credits";
            this.t_credits.Size = new System.Drawing.Size(232, 13);
            this.t_credits.TabIndex = 7;
            this.t_credits.Text = "tool by: karmadah | most scripts: joern ";
            // 
            // gb_gaming
            // 
            this.gb_gaming.Controls.Add(this.b_gaming_throttle);
            this.gb_gaming.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_gaming.Location = new System.Drawing.Point(9, 256);
            this.gb_gaming.Name = "gb_gaming";
            this.gb_gaming.Size = new System.Drawing.Size(347, 59);
            this.gb_gaming.TabIndex = 6;
            this.gb_gaming.TabStop = false;
            this.gb_gaming.Text = "GAMING";
            // 
            // b_gaming_throttle
            // 
            this.b_gaming_throttle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_gaming_throttle.Location = new System.Drawing.Point(6, 20);
            this.b_gaming_throttle.Name = "b_gaming_throttle";
            this.b_gaming_throttle.Size = new System.Drawing.Size(335, 33);
            this.b_gaming_throttle.TabIndex = 4;
            this.b_gaming_throttle.Text = "REMOVE POWER THROTTLE";
            this.b_gaming_throttle.UseVisualStyleBackColor = true;
            this.b_gaming_throttle.Click += new System.EventHandler(this.b_gaming_throttle_Click);
            // 
            // b_enable_cortana
            // 
            this.b_enable_cortana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_enable_cortana.Location = new System.Drawing.Point(3, 323);
            this.b_enable_cortana.Name = "b_enable_cortana";
            this.b_enable_cortana.Size = new System.Drawing.Size(364, 23);
            this.b_enable_cortana.TabIndex = 6;
            this.b_enable_cortana.Text = "REENABLE CORTANA";
            this.b_enable_cortana.UseVisualStyleBackColor = true;
            this.b_enable_cortana.Click += new System.EventHandler(this.b_enable_cortana_Click);
            // 
            // gb_general
            // 
            this.gb_general.Controls.Add(this.b_general_advanced);
            this.gb_general.Controls.Add(this.b_general_bloat);
            this.gb_general.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_general.Location = new System.Drawing.Point(11, 176);
            this.gb_general.Name = "gb_general";
            this.gb_general.Size = new System.Drawing.Size(347, 74);
            this.gb_general.TabIndex = 5;
            this.gb_general.TabStop = false;
            this.gb_general.Text = "GENERAL PERFORMANCE";
            // 
            // b_general_advanced
            // 
            this.b_general_advanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_general_advanced.Location = new System.Drawing.Point(8, 30);
            this.b_general_advanced.Name = "b_general_advanced";
            this.b_general_advanced.Size = new System.Drawing.Size(150, 23);
            this.b_general_advanced.TabIndex = 4;
            this.b_general_advanced.Text = "ADVANCED SETTINGS ";
            this.b_general_advanced.UseVisualStyleBackColor = true;
            this.b_general_advanced.Click += new System.EventHandler(this.b_general_advanced_Click);
            // 
            // b_general_bloat
            // 
            this.b_general_bloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_general_bloat.Location = new System.Drawing.Point(181, 30);
            this.b_general_bloat.Name = "b_general_bloat";
            this.b_general_bloat.Size = new System.Drawing.Size(150, 23);
            this.b_general_bloat.TabIndex = 3;
            this.b_general_bloat.Text = "REMOVE BLOAT";
            this.b_general_bloat.UseVisualStyleBackColor = true;
            this.b_general_bloat.Click += new System.EventHandler(this.b_general_bloat_Click);
            // 
            // gb_disabled
            // 
            this.gb_disabled.Controls.Add(this.cb_disable_services);
            this.gb_disabled.Controls.Add(this.cb_disable_reboot);
            this.gb_disabled.Controls.Add(this.cb_disable_cortana);
            this.gb_disabled.Controls.Add(this.cb_disable_windows_updates);
            this.gb_disabled.Controls.Add(this.b_disable_apply);
            this.gb_disabled.Controls.Add(this.cb_disable_app_updates);
            this.gb_disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_disabled.Location = new System.Drawing.Point(11, 18);
            this.gb_disabled.Name = "gb_disabled";
            this.gb_disabled.Size = new System.Drawing.Size(347, 152);
            this.gb_disabled.TabIndex = 2;
            this.gb_disabled.TabStop = false;
            this.gb_disabled.Text = "DISABLED";
            // 
            // cb_disable_services
            // 
            this.cb_disable_services.AutoSize = true;
            this.cb_disable_services.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_disable_services.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_disable_services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_disable_services.Location = new System.Drawing.Point(6, 118);
            this.cb_disable_services.Name = "cb_disable_services";
            this.cb_disable_services.Size = new System.Drawing.Size(191, 17);
            this.cb_disable_services.TabIndex = 7;
            this.cb_disable_services.Text = "Disable Unnecessary Services";
            this.cb_disable_services.UseVisualStyleBackColor = true;
            // 
            // cb_disable_reboot
            // 
            this.cb_disable_reboot.AutoSize = true;
            this.cb_disable_reboot.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_disable_reboot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_disable_reboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_disable_reboot.Location = new System.Drawing.Point(6, 95);
            this.cb_disable_reboot.Name = "cb_disable_reboot";
            this.cb_disable_reboot.Size = new System.Drawing.Size(225, 17);
            this.cb_disable_reboot.TabIndex = 6;
            this.cb_disable_reboot.Text = "Disable Forced Reboot After Update";
            this.cb_disable_reboot.UseVisualStyleBackColor = true;
            // 
            // cb_disable_cortana
            // 
            this.cb_disable_cortana.AutoSize = true;
            this.cb_disable_cortana.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_disable_cortana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_disable_cortana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_disable_cortana.Location = new System.Drawing.Point(6, 72);
            this.cb_disable_cortana.Name = "cb_disable_cortana";
            this.cb_disable_cortana.Size = new System.Drawing.Size(179, 17);
            this.cb_disable_cortana.TabIndex = 5;
            this.cb_disable_cortana.Text = "Disable Cortana Completely";
            this.cb_disable_cortana.UseVisualStyleBackColor = true;
            // 
            // cb_disable_windows_updates
            // 
            this.cb_disable_windows_updates.AutoSize = true;
            this.cb_disable_windows_updates.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_disable_windows_updates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_disable_windows_updates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_disable_windows_updates.Location = new System.Drawing.Point(6, 49);
            this.cb_disable_windows_updates.Name = "cb_disable_windows_updates";
            this.cb_disable_windows_updates.Size = new System.Drawing.Size(229, 17);
            this.cb_disable_windows_updates.TabIndex = 4;
            this.cb_disable_windows_updates.Text = "Disable Automatic Windows Updates";
            this.cb_disable_windows_updates.UseVisualStyleBackColor = true;
            // 
            // b_disable_apply
            // 
            this.b_disable_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_disable_apply.Location = new System.Drawing.Point(272, 12);
            this.b_disable_apply.Name = "b_disable_apply";
            this.b_disable_apply.Size = new System.Drawing.Size(69, 134);
            this.b_disable_apply.TabIndex = 3;
            this.b_disable_apply.Text = "APPLY";
            this.b_disable_apply.UseVisualStyleBackColor = true;
            this.b_disable_apply.Click += new System.EventHandler(this.b_disable_apply_Click);
            // 
            // cb_disable_app_updates
            // 
            this.cb_disable_app_updates.AutoSize = true;
            this.cb_disable_app_updates.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_disable_app_updates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_disable_app_updates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_disable_app_updates.Location = new System.Drawing.Point(6, 26);
            this.cb_disable_app_updates.Name = "cb_disable_app_updates";
            this.cb_disable_app_updates.Size = new System.Drawing.Size(201, 17);
            this.cb_disable_app_updates.TabIndex = 0;
            this.cb_disable_app_updates.Text = "Disable Automatic App Updates";
            this.cb_disable_app_updates.UseVisualStyleBackColor = true;
            // 
            // b_reboot
            // 
            this.b_reboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_reboot.Location = new System.Drawing.Point(3, 352);
            this.b_reboot.Name = "b_reboot";
            this.b_reboot.Size = new System.Drawing.Size(364, 23);
            this.b_reboot.TabIndex = 1;
            this.b_reboot.Text = "REBOOT";
            this.b_reboot.UseVisualStyleBackColor = true;
            this.b_reboot.Click += new System.EventHandler(this.b_reboot_Click);
            // 
            // f_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(371, 438);
            this.Controls.Add(this.p_body);
            this.Controls.Add(this.p_header);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f_main";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Octane Performance Booster";
            this.Load += new System.EventHandler(this.f_main_Load);
            this.p_header.ResumeLayout(false);
            this.p_header.PerformLayout();
            this.p_body.ResumeLayout(false);
            this.p_body.PerformLayout();
            this.gb_gaming.ResumeLayout(false);
            this.gb_general.ResumeLayout(false);
            this.gb_disabled.ResumeLayout(false);
            this.gb_disabled.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_header;
        private System.Windows.Forms.Panel p_body;
        private System.Windows.Forms.Label t_min;
        private System.Windows.Forms.Label t_exit;
        private System.Windows.Forms.CheckBox cb_disable_app_updates;
        private System.Windows.Forms.Button b_reboot;
        private System.Windows.Forms.GroupBox gb_disabled;
        private System.Windows.Forms.Button b_disable_apply;
        private System.Windows.Forms.CheckBox cb_disable_services;
        private System.Windows.Forms.CheckBox cb_disable_reboot;
        private System.Windows.Forms.CheckBox cb_disable_cortana;
        private System.Windows.Forms.CheckBox cb_disable_windows_updates;
        private System.Windows.Forms.Button b_general_advanced;
        private System.Windows.Forms.Button b_general_bloat;
        private System.Windows.Forms.GroupBox gb_gaming;
        private System.Windows.Forms.Button b_gaming_throttle;
        private System.Windows.Forms.Button b_enable_cortana;
        private System.Windows.Forms.GroupBox gb_general;
        private System.Windows.Forms.Label t_credits;
        private System.Windows.Forms.Label t_form_name;
    }
}

