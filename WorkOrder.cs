using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cargolator
{
    [Serializable]
    public class WorkOrder : Ship
    {
        public int Wo { get; set; }
        public int MCflag { get; set; }
        public WorkOrder() { }
        public WorkOrder(int countainer,int crew, int speed, int cost)
        {
            ContainerCount = countainer;
            CrewCount = crew;
            Speed = speed;
            Cost = cost;
            if (Cost == 0) MCflag = 1;
            else MCflag = 0;
        }
        public WorkOrder(int woNum)
        {
            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            var fi = new System.IO.FileInfo(@"orderList.bin");
            Dictionary<int, WorkOrder> readBack;
            using (var binaryFile = fi.OpenRead()) readBack = (Dictionary<int, WorkOrder>)binaryFormatter.Deserialize(binaryFile);
            Speed = readBack[woNum].Speed;
            MCflag = readBack[woNum].MCflag;
            readBack.Clear();
        }
    }
}
