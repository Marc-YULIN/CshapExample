using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Car
{
    public class BMW : _BaseCar
    {
        public BMW(string model) : base(logo: "BMW", cc: 2000, model: model)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"{logo}我很貴 => 我的型號是{model}");
        }
    }
}
