using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Car;

namespace Transportation.Factory
{
    /// <summary>
    /// 簡單工廠
    /// 實作後缺陷
    /// 1.違反 OCP原則
    /// 2.無法針對各品牌設計出不同型號的汽車
    /// </summary>
    public class SimpleFactory
    {
        public static _BaseCar GenerateCar(CarType type)
        {
            switch (type)
            {
                case CarType.Audi:
                    Console.WriteLine("開始製造 Audi");
                    return new Audi("A1");
                case CarType.BMW:
                    Console.WriteLine("開始製造 BMW");
                    return new BMW("X7");
                case CarType.Tesla:
                    Console.WriteLine("開始製造 Tesla");
                    return new Tesla("Model3");
                default:
                    return null;
            }
        }
    }
}
