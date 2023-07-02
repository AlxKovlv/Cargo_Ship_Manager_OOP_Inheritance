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
    public partial class Delete : Form
    {
        private static Dictionary<int, WorkOrder> orderList = new Dictionary<int, WorkOrder>();
        public Delete()
        {
            InitializeComponent();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int temp;
            if (int.TryParse(textBox.Text, out temp) == true) {

                temp = Int32.Parse(textBox.Text);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                var fi = new System.IO.FileInfo(@"orderList.bin");

                using (var binaryFile = fi.OpenRead())
                {
                    orderList = (Dictionary<int, WorkOrder>)binaryFormatter.Deserialize(binaryFile);
                }

                if (orderList.ContainsKey(temp))
                {
                    orderList.Remove(temp);
                    File.WriteAllText(@"file.Report.txt", "\nShipment number: " + temp + "\nDeleted successfully");
                    Info info = new Info();
                    info.Show();

                    Close();
                }
                else
                {
                    File.WriteAllText(@"file.Report.txt", "\nERROR!\nShipment number: " + temp + "\nDoes not exist");
                    Info info = new Info();
                    info.Show();
                    Close();
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
                info.Show(); 
                return;
            }
        }
    }
}
