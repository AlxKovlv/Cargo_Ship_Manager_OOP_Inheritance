using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cargolator
{
    public partial class Report : Form
    {
        public Report(Dictionary<int, WorkOrder> readBack)
        {
            InitializeComponent();
            lbl_heads.Text = "M.Contract      Work order       Containers     Ship speed    Fuel cost";
            updateUI(readBack);

        }
        private void updateUI(Dictionary<int, WorkOrder> readBack)
        {
            foreach (var kvp in readBack)
            {
                if (kvp.Value.MCflag != 0)
                {
                    if (kvp.Value.MCflag == 2) lbl_mc.Text += "*";
                    lbl_mc.Text += "[V]";
                    lbl_mc.Text += "\n";
                }
                else lbl_mc.Text += "[  ]\n";
                lbl_wo.Text += kvp.Value.Wo + "\n";
                lbl_containers.Text += kvp.Value.ContainerCount + "\n";
                lbl_speed.Text += kvp.Value.Speed + "knots\n";
                lbl_cost.Text += kvp.Value.Cost + "$\n";
            }
        }

        private void lbl_report_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {

        }
    }
}
