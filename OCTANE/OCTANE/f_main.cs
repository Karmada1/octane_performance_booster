using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCTANE
{
    public partial class f_main : Form
    {
        public f_main()
        {
            InitializeComponent();
        }

        private void f_main_Load(object sender, EventArgs e)
        {
            //p_ad.BackgroundImage = Image.FromFile(@"advert.png");
        }

        private void t_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void t_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void b_disable_apply_Click(object sender, EventArgs e)
        {
            if (cb_disable_app_updates.Checked == true)
                System.Diagnostics.Process.Start("Disable Automatic App Updates.bat");

            if (cb_disable_windows_updates.Checked == true)
                System.Diagnostics.Process.Start("Disable Automatic Windows Updates.bat");

            if (cb_disable_cortana.Checked == true)
                System.Diagnostics.Process.Start("Disable Cortana Completely.bat");

            if (cb_disable_reboot.Checked == true)
                System.Diagnostics.Process.Start("Disable Forced Reboot After Update.bat");

            if (cb_disable_services.Checked == true)
                System.Diagnostics.Process.Start("Disable Unnecessary Services.bat");
        }

        private void b_general_advanced_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Advanced Explorer Settings.bat");
        }

        private void b_general_bloat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Uninstall Unnecessary Apps.bat");
        }

        private void b_enable_cortana_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Reenable Cortana Completely.bat");
        }

        private void b_gaming_throttle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Remove Power Throttle.bat");
        }

        private void b_reboot_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Reboot.bat");
        }
    }
}
