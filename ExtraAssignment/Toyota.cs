using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAssignment
{
    class Toyota : IGasolineEngine, IBreakable
    {
        private float capacity;

        public Toyota(float capacity)
        {

        }

        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void Inject()
        {
            throw new NotImplementedException();
        }
    }
}
