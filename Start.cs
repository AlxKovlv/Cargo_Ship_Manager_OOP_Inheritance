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
using System.Runtime.Serialization;

namespace Cargolator
{
    public partial class Start : Form
    {

        public Start()
        {
            InitializeComponent();
            updateUI();
        }
        private void updateUI()
        {

        }

        private void btn_newShipment_Click(object sender, EventArgs e)
        {
            Cargolator form1 = new Cargolator();
            form1.Show();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            var fi = new System.IO.FileInfo(@"orderList.bin");
            Dictionary<int, WorkOrder> readBack;

            using (var binaryFile = fi.OpenRead())
            {
                readBack = (Dictionary<int, WorkOrder>)binaryFormatter.Deserialize(binaryFile);
            }

            Report report = new Report(readBack);
            report.Show();

        }

        private void btn_deleteWo_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }

        private void btn_mc_Click(object sender, EventArgs e)
        {
            
            int temp = Int32.Parse(File.ReadAllText(@"MilitaryCredit.txt"));
            if (temp != 0){
                MCredit credit = new MCredit();
                credit.Show();
            }
            else
            {
                btn_mc.ForeColor = Color.Red;
                File.WriteAllText(@"file.Report.txt", "\nOption blocked!\nPlease revise military contract");
                Info info = new Info();
                info.Show();
                return;
            }
        }

        private void btn_cypher_Click(object sender, EventArgs e)
        {
            EncryptionCenter ec = new EncryptionCenter();
            ec.Show();
        }
    }
}
