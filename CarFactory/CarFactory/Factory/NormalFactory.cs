using Transportation.Airplane;
using Transportation.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Factory
{
    /// <summary>
    /// 抽象工廠
    /// </summary>
    public abstract class NormalFactory
    {
        public abstract _BaseCar GenerateCar(string model);

        public abstract _BaseAirplane GenerateAirplane(string model);
    }
}
