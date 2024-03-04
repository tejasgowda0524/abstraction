using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class passengerplane : Plane
    {
        public void Fly()
        {
            Console.WriteLine("Passenger plane is flying at low levels");
        }

        public void Land()
        {
            Console.WriteLine("Passenger plane is landing");
        }

        public void TakeOff()
        {
            Console.WriteLine("Passenger plane is taking off");
        }

        public void CarryPassengers()
        {
            Console.WriteLine("Passenger plane carries passengers");
        }
    }
}
