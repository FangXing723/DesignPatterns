using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAndSet
{

    public class People
    {
        // set为私有，只可以在People类的内部去获取
        public string Name { get; private set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public int Age { get; set; }

        public string GetPeopleInfo()
        {
            return string.Format("姓名={0}，年龄={1}", Name, Age);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            People GuHongXin = new People()
            {
                //Name = "顾洪鑫",
                Age = 23
            };
            GuHongXin.SetName("顾洪鑫");

            Console.WriteLine(GuHongXin.GetPeopleInfo());







            Console.ReadKey();

            Environment.Exit(0);
            GC.Collect(0);

        }
    }



}
