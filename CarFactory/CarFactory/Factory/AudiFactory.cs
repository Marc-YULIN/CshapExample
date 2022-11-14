using Transportation.Airplane;
using Transportation.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Factory
{
    public class AudiFactory : NormalFactory
    {
        public override _BaseAirplane GenerateAirplane(string model)
        {
            throw new NotImplementedException();
        }

        public override _BaseCar GenerateCar(string model)
        {
            Console.WriteLine("開始製造 Audi");
            return new Audi(model);
        }
    }
}
