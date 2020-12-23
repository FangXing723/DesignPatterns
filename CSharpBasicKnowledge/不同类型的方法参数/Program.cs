using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 不同类型的方法参数
{
    class Program
    {
        static void Exchange(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }


        static void Exchange_Ref(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }


        static void Exchange_Out(int a ,int b,out string result)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

            result = string.Format("a={0},b={1}", a, b);
        }


        static void Method_UseParams(params object[] list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 24;
            Console.WriteLine("初始数据");
            Console.WriteLine("a={0},b={1}", a, b);



            Console.WriteLine("值参数类型：无修饰符");
            Exchange(a, b);
            Console.WriteLine("a={0},b={1}", a, b);



            Console.WriteLine("引用参数类型：ref");
            Exchange_Ref(ref a, ref b);
            Console.WriteLine("a={0},b={1}", a, b);




            Console.WriteLine("输出参数类型：out");
            Exchange_Out(a, b, out string result);
            Console.WriteLine(result);




            Console.WriteLine("数组型参数类型：params");
            object[] list = new object[3];
            list[0] = DateTime.Now;
            list[1] = "天气：晴朗";
            list[2] = DateTime.UtcNow;
            Method_UseParams(list);




            Console.ReadKey();
            Environment.Exit(0);
            GC.Collect(0);
        }
    }
}
