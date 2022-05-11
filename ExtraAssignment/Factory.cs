using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAssignment
{
    
    class Factory
    {
        Vehicle vehicle = new Car();
        public static void Instance()
        { 
        
        }
        private Factory()
        {

        }
        public Vehicle Create(int type)
        {
            return vehicle;
        }
    }
}
