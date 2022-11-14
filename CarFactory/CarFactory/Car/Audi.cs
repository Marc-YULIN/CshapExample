using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Car
{
    public class Audi : _BaseCar
    {
        public Audi(string model) : base(logo: "Audi", cc: 1500, model: model)
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"我的廠牌是{logo}，我的排氣量為{cc}行駛喔!!");
        }

        public override void Sound()
        {
            Console.WriteLine($"我是 {logo},我的型號是{model}");
        }
    }
}
