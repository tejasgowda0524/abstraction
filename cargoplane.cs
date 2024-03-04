using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    public class cargoplane : Plane
    {
        public void Fly()
        {
            Console.WriteLine("Cargo plane is flying at medium levels");
        }

        public void Land()
        {
            Console.WriteLine("Cargo plane is landing");
        }

        public void TakeOff()
        {
            Console.WriteLine("Cargo plane is taking off");
        }

        public void CarryCargo()
        {
            Console.WriteLine("Cargo plane carries cargo");
        }
    }
}
