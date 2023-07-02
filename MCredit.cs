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
    public partial class MCredit : Form
    {
        private int temp;
        private string credit = File.ReadAllText(@"MilitaryCredit.txt");
        private static Dictionary<int, WorkOrder> orderList = new Dictionary<int, WorkOrder>();
        private MilitaryContract tempMc = new MilitaryContract();

        public MCredit()
        {
            InitializeComponent();
            updateUI();
        }
        private void updateUI()
        {
            lbl_score.Text = credit;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_credit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_mc.Text, out temp) == true)
            {
                temp = Int32.Parse(textBox_mc.Text);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                var fi = new System.IO.FileInfo(@"orderList.bin");

                using (var binaryFile = fi.OpenRead())
                {
                    orderList = (Dictionary<int, WorkOrder>)binaryFormatter.Deserialize(binaryFile);
                }

                if (orderList.ContainsKey(temp))
                {
                    if (orderList[temp].Cost == 0)
                    {
                        if (orderList[temp].MCflag == 2)
                        {
                            File.WriteAllText(@"file.Report.txt", "\nERROR!\nMilitary contract: " + temp + "\nCredit was already collected");
                            Info info = new Info();
                            info.Show();
                            return;
                        }
                        else
                        {
                            orderList[temp].MCflag = 2;
                            tempMc.Speed = orderList[temp].Speed;
                            tempMc.giveCredit();
                            tempMc.checkContract();
                            File.WriteAllText(@"file.Report.txt", "\nWork order number: " + temp + "\nMilitary credit collected");
                            Info info = new Info();
                            info.Show();
                            Close();
                        }
                    }
                    else
                    {
                        File.WriteAllText(@"file.Report.txt", "\nERROR!\nWork order number: " + temp + "\nIs not a military Contract");
                        Info info = new Info();
                        info.Show();
                        return;
                    }
                }
                else
                {
                    File.WriteAllText(@"file.Report.txt", "\nERROR!\nMilitary contract: " + temp + "\nDoes not exist");
                    Info info = new Info();
                    info.Show();
                    return;
                }

                using (var binaryFile = fi.Create())
                {
                    binaryFormatter.Serialize(binaryFile, orderList);
                    binaryFile.Flush();
                }

            }
            else
            {
                File.WriteAllText(@"file.Report.txt", "\nERROR!\nOnly numeric values allowed");
                Info info = new Info();
                info.Show(); ;
                return;
            }
        }

        private void MCredit_Load(object sender, EventArgs e)
        {

        }
    }
}
