using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class fighterplane : Plane
    {
        public void Fly()
        {
            Console.WriteLine("fighterplane is flying at high levels");
        }

        public void Land()
        {
            Console.WriteLine("fighterplane is landing");
        }

        public void TakeOff()
        {
            Console.WriteLine("fighterplane is taking off");
        }

        public void CarryCargo()
        {
            Console.WriteLine("fighterplane carries cargo");
        }
    }
}
