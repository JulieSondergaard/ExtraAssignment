using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAssignment
{
    class Bicycle : IBreakable
    {
        private string registrationNumber;
        List<Wheel> wheels = new List<Wheel>();

        public Bicycle(int numberOfWheels) 
        {
        
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }
    }
}
