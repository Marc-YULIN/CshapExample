using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Airplane;
using Transportation.Car;

namespace Transportation.Factory
{
    public class TeslaFactory : NormalFactory
    {
        public override _BaseAirplane GenerateAirplane(string model)
        {
            throw new NotImplementedException();
        }

        public override _BaseCar GenerateCar(string model)
        {
            Console.WriteLine("開始製造 Tesla");
            return new Tesla(model);
        }
    }
}
