using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace async_await异步测试
{

    class InFreshAir
    {
        /// <summary>
        /// 开门
        /// </summary>
        public static void OpenTheDoor()
        {
            Console.WriteLine("Tom打开了门");
            FreshTheRoomAsync();
            Console.WriteLine("Jerry溜了进来！");
        }

        /// <summary>
        /// 通风
        /// </summary>
        /// <returns></returns>
        private static async Task FreshTheRoomAsync()
        {
            var freshAir = await MakeFreshAir();


            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(freshAir);
            }
        }


        private static Task<string> MakeFreshAir()
        {
            var task = Task.Run(() =>
            {
                return "呼~呼~呼~";
            });

            return task;
        }

    }


    class Program
    {

        static void Main(string[] args)
        {

            InFreshAir.OpenTheDoor();

            Console.ReadKey();

            Environment.Exit(0);
            GC.Collect(0);


        }
    }
}
