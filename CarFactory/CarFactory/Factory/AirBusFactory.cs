using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Airplane;
using Transportation.Car;

namespace Transportation.Factory
{
    public class AirBusFactory : NormalFactory
    {

        public override _BaseAirplane GenerateAirplane(string model)
        {
            Console.WriteLine("開始製造 AirBus");
            return new AirBus(model);
        }

        public override _BaseCar GenerateCar(string model)
        {
            throw new NotImplementedException();
        }
    }
}
