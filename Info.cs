using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cargolator
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            string ReportPath = @"file.Report.txt";
            string rep = File.ReadAllText(ReportPath);
            label1.Text = rep;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
