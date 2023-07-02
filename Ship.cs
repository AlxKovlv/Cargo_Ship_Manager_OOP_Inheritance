using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargolator
{
    [Serializable]
    abstract public class Ship
    {
        public const int CONTAINER_WEIGHT = 10;
        public const int CREW_WEIGHT = 2;
        public Ship() { }
        public int Capacity { get; set; } = 0;
        public int Speed { get; set; } = 0;
        public int Cost { get; set; } = 0;
        public int ContainerCount { get; set; } = 0;
        public int CrewCount { get; set; } = 0;
        public int GetShipLoad() { return ContainerCount * CONTAINER_WEIGHT + CrewCount * CREW_WEIGHT; }
    }
}
