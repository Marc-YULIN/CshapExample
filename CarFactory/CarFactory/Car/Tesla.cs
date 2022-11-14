using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Car
{
    public class Tesla : _BaseCar
    {
        public Tesla(string model) : base(logo: "Tesla", cc: 0, model: model)
        {

        }

        public override void Sound()
        {
            Console.WriteLine($"我是{logo}會自動駕駛 => 我的型號是{model}");
        }
    }
}
