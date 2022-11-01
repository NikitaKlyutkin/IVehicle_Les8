using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVehicle_Les8
{
    internal interface IVehicle
    {
        public void Drive(int dist);
        public void Refuel(int benz);
    }
}
