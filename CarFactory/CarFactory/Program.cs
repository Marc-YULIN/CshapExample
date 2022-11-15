using System;
using System.Runtime.ConstrainedExecution;
using Transportation.Airplane;
using Transportation.Car;
using Transportation.Factory;

namespace Transportation // Note: actual namespace depends on the project name.
{
    public class Program
    {
        /*
         請設計一套系統，這個系統是關於 "交通工具"
        以 "汽車" 為例
        Audi 奧迪
        BMW 寶馬
        Tesla 特斯拉

        每台汽車有自己的
        1. 廠牌
        2. 排氣量
        3. 型號

        工廠在產生車子的時候，每台車子都會有
        1. 生產序號
        2. 生產時間

        每台車子都有以下行為
        1. Drive - 使用自己的排氣量行駛
        2. Sound - 喊出自己的型號

        請自己設計一套工廠可以製造出各種型號的汽車
        並且讓他在道路上面行駛

        注意有些東西在車子生產出來之後就不能再改

        衍伸題目:
        如果這個工廠之後要設計飛機，怎麼辦?
         
         */
        static void Main(string[] args)
        {
            #region Simple Factory
            //var cars = new List<Car>()
            //{
            //    SimpleFactory.GenerateCar(CarType.Audi),
            //    SimpleFactory.GenerateCar(CarType.Tesla),
            //    SimpleFactory.GenerateCar(CarType.BMW)
            //};

            //foreach (var car in cars)
            //{
            //    car.Sound();
            //    Console.WriteLine($"生產日期:{car.GetCreateDate} 生產序號:{car.GetSerialNumber}");
            //}

            #endregion Simple Factory

            #region Factory
            NormalFactory audiFactory = new AudiFactory();
            _BaseCar carA = audiFactory.GenerateCar("A1");
            carA.Drive();
            carA.Sound();
            carA.GetCreateDate();
            carA.GetSerialNumber();
            Console.WriteLine();

            NormalFactory bmwFactory = new BMWFactory();
            _BaseCar carB = bmwFactory.GenerateCar("X7");
            carB.Drive();
            carB.Sound();
            carB.GetCreateDate();
            carB.GetSerialNumber();
            Console.WriteLine();

            NormalFactory teslaFactory = new TeslaFactory();
            _BaseCar carC = teslaFactory.GenerateCar("Model3");
            carC.Drive();
            carC.Sound();
            carC.GetCreateDate();
            carC.GetSerialNumber();
            Console.WriteLine();

            //衍伸題目:
            //如果這個工廠之後要設計飛機，怎麼辦?

            NormalFactory airBusFactory = new AirBusFactory();
            _BaseAirplane airA = airBusFactory.GenerateAirplane("A320");
            airA.Drive();
            airA.Sound();
            airA.GetCreateDate();
            airA.GetSerialNumber();
            #endregion Factory
        }
    }
}