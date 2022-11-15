using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Car
{
    abstract public class _BaseCar
    {
        /// <summary>
        /// 廠牌
        /// </summary>
        protected string logo;
        /// <summary>
        /// 排氣量
        /// </summary>
        protected int cc;
        /// <summary>
        /// 型號
        /// </summary>
        protected string model;

        private string serialNumber;

        private string createDate;

        public _BaseCar(string logo, int cc, string model)
        {
            this.logo = logo;
            this.cc = cc;
            this.model = model;
            this.serialNumber = Guid.NewGuid().ToString();
            this.createDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff:ffffff");
        }

        /// <summary>
        /// Drive - 使用自己的排氣量行駛
        /// </summary>
        public virtual void Drive()
        {
            Console.WriteLine($"我的排氣量為{cc}行駛喔!!");
        }

        /// <summary>
        /// Sound - 喊出自己的型號
        /// </summary>
        abstract public void Sound();


        public void GetSerialNumber()
        {
            Console.WriteLine($"我的生產時間:{createDate}");
        }

        public void GetCreateDate()
        {
            Console.WriteLine($"我的生產序號:{serialNumber}");
        }

    }
}
