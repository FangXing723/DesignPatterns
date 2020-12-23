using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns._2CLMS.CashTypeEnum;

namespace DesignPatterns._2CLMS
{
    /// <summary>
    /// 设计模式：策略模式
    /// 用例情况：超市收费系统
    /// 用法情况：用来封装算法
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            // 提示用户有哪些类型
            foreach (var cashItem in Enum.GetValues(typeof(CashType)))
            { Console.WriteLine((int)cashItem + ":" + cashItem); }

            Console.WriteLine("请输入折扣类型");



            // 获取折扣类型序号
            int cashTypeIndex = int.Parse(Console.ReadLine().Trim());
            // 获取收费类型枚举对象
            CashType type = (CashType)Enum.Parse(typeof(CashType), cashTypeIndex.ToString());

            // 根据类型去适配上下文
            CashContext context = new CashContext(type);


            Console.WriteLine("请输入总金额：");
            double money = double.Parse(Console.ReadLine().Trim());


            double resultMoney = context.GetResult(money);
            Console.WriteLine("最终金额：" + resultMoney);





            // 善后处理
            Console.ReadKey();
            Environment.Exit(0);
            GC.Collect(0);


        }
    }
}
