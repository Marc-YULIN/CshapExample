using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Airplane
{
    public class AirBus : _BaseAirplane
    {
        public AirBus(string model) : base(logo:"空中巴士", cc: 24000, model)
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"我的廠牌是{logo}，我的 CC數為{cc} 飛行喔!!");
        }

        public override void Sound()
        {
            Console.WriteLine($"我是 {logo},我的型號是{model}");
        }
    }
}
