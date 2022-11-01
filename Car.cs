using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVehicle_Les8
{
    internal abstract class Car : IVehicle
    {
        public int _rashod { get;private set; }
        public int _benz { get;private set; }
        public Car(int rashod)
        {
            _rashod = rashod;
        }

        public void Drive(int dist)
        {
            int litr = dist * _rashod;

            if (litr > _benz)
            {
                Console.WriteLine("Not enough ");
                return;
            }
            else
                Console.WriteLine("Start Drive");
            _benz = _benz - litr;
        }

        public void Refuel(int benz)
        {
            _benz =_benz + benz;
        } 
    }
}
