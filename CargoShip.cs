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
    public class CargoShip:Ship
    {
        private static Dictionary<int, WorkOrder> orderList = new Dictionary<int, WorkOrder>();

        public CargoShip() 
        {
            Capacity = 200;
            Speed = 50;
            Cost = 2000;
        }
        public void Priotiry()
        {
            Speed *= 2;
            Cost *= 2;
        }
        public void Stacking()
        {
            Capacity *= 2;
            Cost *= 2;
            Speed /= 2;
        }

        public int OverUnder()
        {
            return Capacity - GetShipLoad();
        }

        public string WriteString()
        {
            return "Ship capacity = " + Capacity + ", current load = " + GetShipLoad();
        }

        public void nextOrder()
        {
            int woNum = Int32.Parse(File.ReadAllText(@"Work_order.txt"));
            woNum++;
            File.WriteAllText(@"Work_order.txt", woNum.ToString());
        }

        public void updateList(CargoShip ship)
        {
            int woNum = Int32.Parse(File.ReadAllText(@"Work_order.txt"));
            WorkOrder tempWo = new WorkOrder(ship.ContainerCount, ship.CrewCount, ship.Speed, ship.Cost);
            tempWo.Wo = woNum;
            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            var fi = new System.IO.FileInfo(@"orderList.bin");
            using (var binaryFile = fi.OpenRead())
            {
                orderList = (Dictionary<int, WorkOrder>)binaryFormatter.Deserialize(binaryFile);
            }
            orderList.Add(woNum, tempWo);
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, orderList);
                binaryFile.Flush();
            }
        }
    }
}
