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

    public partial class Cargolator : Form
    {
        
        CargoShip ship = new CargoShip();
        string woNum = File.ReadAllText(@"Work_order.txt");


        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label_containerCount_Click(object sender, EventArgs e)
        {

        }
        private void check_priority_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void check_stacking_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void check_stacking_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void lbl_maxCap_Click(object sender, EventArgs e)
        {

        }
        private void label_wo_Click(object sender, EventArgs e)
        {

        }

        public Cargolator()
        {
            InitializeComponent();
            updateUI();
        }

        private void btn_newShipment_Click(object sender, EventArgs e)
        {
            ship = new CargoShip();
            if (check_stacking.Checked) ship.Stacking();
            if (check_priority.Checked) ship.Priotiry();
            if (check_military.Checked) ship.Cost=0;
            updateUI();
        }

        private void updateUI()
        {
            progressBar1.Maximum = ship.Capacity;
            if (ship.GetShipLoad() <= ship.Capacity) progressBar1.Value = ship.GetShipLoad();
            label_shipLabel.Text = ship.WriteString();
            label_containerCount.Text = ship.ContainerCount.ToString();
            label_crew.Text = ship.CrewCount.ToString();
            label_wo.Text = woNum;
            if (ship.OverUnder() == 0) { progressBar1.ForeColor = Color.Green; lbl_maxCap.Text = "|   Maximum capacity reached"; }
            if (ship.OverUnder() > 0) {progressBar1.ForeColor = Color.LightSteelBlue; lbl_maxCap.Text = null; }
            if (ship.OverUnder() < 0) progressBar1.ForeColor = Color.Red;
        }

        private void track_containers_Scroll(object sender, EventArgs e)
        {
            ship.ContainerCount = track_containers.Value;
            updateUI();
        }

        private void track_crew_Scroll(object sender, EventArgs e)
        {
            ship.CrewCount = track_crew.Value;
            updateUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
        }

        private void track_crew_Scroll_1(object sender, EventArgs e)
        {
            ship.CrewCount = track_crew.Value;
            updateUI();
        }

        private void btn_preview_click(object sender, EventArgs e)
        {
            if (progressBar1.ForeColor == Color.Red) tryAgain();
            else previewInfo();
        }


        private void btn_save_click(object sender, EventArgs e)
        {
            if (progressBar1.ForeColor == Color.Red) tryAgain();

            else
            {
                ship.updateList(ship);
                successMssg();
                ship.nextOrder();
                Close();
            }
        }


        private void tryAgain()
        {
            string infoStr = "\nERROR!\nThe ship is overloaded\n";
            File.WriteAllText(@"file.Report.txt", infoStr);
            Info info = new Info();
            info.Show();
        }

        private void successMssg()
        {
            string wo = File.ReadAllText(@"Work_order.txt");
            string infoStr = "\nShipment number: "+wo+"\nSaved successfully";
            File.WriteAllText(@"file.Report.txt", infoStr);
            Info info = new Info();
            info.Show();
        }

        private void previewInfo()
        {
            string infoStr = "Work order: " + woNum + "\nShip cargo: " + ship.ContainerCount + " containers" + "\nCrew on board: " + ship.CrewCount + "\nShip speed: " + ship.Speed + " knots" + "\nFuel cost: " + ship.Cost + "$";
            if (ship.Cost == 0) infoStr += " (Military contract)";
            File.WriteAllText(@"file.Report.txt", infoStr);
            Info info = new Info();
            info.Show();
        }




















        private void check_priority_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Shipment will arrive faster\nFuel cost will be increased",check_priority);
        }

        private void check_stacking_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Ship capacity will be increased\nFuel cost will be increased", check_stacking);
        }

        private void check_military_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Fuel cost is covered by the military contract", check_military);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
