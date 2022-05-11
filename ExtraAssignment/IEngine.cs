using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAssignment
{
    interface IEngine: IGasolineEngine
    {
        public void Start();
        public void TurnOff();
    }
}
