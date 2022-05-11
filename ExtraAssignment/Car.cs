using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAssignment
{
    class Car : Vehicle
    {
        private string registrationNumber;
        private string registrationYear;
        private IEngine engine;
        Gearbox gearbox = new Gearbox();
        Wheel frontLeft = new Wheel();
        Wheel frontRight = new Wheel();
        Wheel backLeft = new Wheel();
        Wheel backRight = new Wheel();

        public void Start()
        {

        }

        protected override void TurnLeft(float degrees)
        {
            throw new NotImplementedException();
        }

        internal Car()
        {

        }
        public Car(string color)
        {

        }

        public Car(string color, float size)
        {

        }

 
    }
}
