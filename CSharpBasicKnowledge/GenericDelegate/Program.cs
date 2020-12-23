using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    /// <summary>
    /// 操作类型枚举
    /// </summary>
    public enum OperateType
    {
        Subtract,
        Add
    }


    /// <summary>
    /// 使用delegate定义有返回值的委托
    /// </summary>
    public class DelegateByDelegate
    {
        // 操作两个数字
        private delegate int OperateTwoNum(int num1, int num2);

        // 相加
        private static int SubtractTwoNum(int num1, int num2)
        {
            return num1 - num2;
        }

        // 相减
        private static int AddTwoNum(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// 根据制定操作类型操作两个数字
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operateType"></param>
        /// <returns></returns>
        public static int GetResuletByOperateTwoNum(int num1, int num2, OperateType operateType)
        {
            int result = 0;


            OperateTwoNum operateTwoNum;
            switch (operateType)
            {
                case OperateType.Subtract:
                    operateTwoNum = SubtractTwoNum;
                    break;
                case OperateType.Add:
                    operateTwoNum = AddTwoNum;
                    break;
                default:
                    operateTwoNum = AddTwoNum;
                    break;
            }


            result = operateTwoNum(num1, num2);

            return result;

        }

    }

    /// <summary>
    /// 使用Action<T1,T2>定义无返回值的委托
    /// </summary>
    public class DelegateByAction
    {

        private static Action<int, int> OperateTwoNum;

        public static void PrintResuletByOperateTwoNum(int num1, int num2, OperateType operateType)
        {

            switch (operateType)
            {
                case OperateType.Subtract:
                    OperateTwoNum = SubtractTwoNum;
                    break;
                case OperateType.Add:
                    OperateTwoNum = AddTwoNum;
                    break;
                default:
                    OperateTwoNum = AddTwoNum;
                    break;
            }


            OperateTwoNum(num1, num2);

        }


        private static void SubtractTwoNum(int num1, int num2)
        {
            Console.WriteLine(string.Format("计算结果={0}", num1 - num2));
        }

        private static void AddTwoNum(int num1, int num2)
        {
            Console.WriteLine(string.Format("计算结果={0}", num1 + num2));
        }
    }

    /// <summary>
    /// 使用泛型Func<T1, T2, TResult>定义具有输出结果的委托
    /// </summary>
    public class DelegateByFunc
    {

        private static Func<int, int,int> GetOperateResult;


        // 相加
        private static int SubtractTwoNum(int num1, int num2)
        {
            return num1 - num2;
        }

        // 相减
        private static int AddTwoNum(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// 根据制定操作类型操作两个数字
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operateType"></param>
        /// <returns></returns>
        public static int GetResuletByOperateTwoNum(int num1, int num2, OperateType operateType)
        {
            
            switch (operateType)
            {
                case OperateType.Subtract:
                    GetOperateResult = SubtractTwoNum;
                    break;
                case OperateType.Add:
                    GetOperateResult = AddTwoNum;
                    break;
                default:
                    GetOperateResult = AddTwoNum;
                    break;
            }


             

            return GetOperateResult(num1, num2);

        }

    }


    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("——————————————————通过Delegate定义有返回值的委托——————————————————");
            Console.WriteLine(string.Format("计算结果={0}", DelegateByDelegate.GetResuletByOperateTwoNum(30, 20, OperateType.Subtract)));

            Console.WriteLine("——————————————————通过Action<T1,T2>定义无返回值的委托——————————————————");
            DelegateByAction.PrintResuletByOperateTwoNum(18, 5, OperateType.Add);

            Console.WriteLine("——————————————————使用泛型Func<T1, T2, TResult>定义具有输出结果的委托——————————————————");
            Console.WriteLine(string.Format("计算结果={0}", DelegateByFunc.GetResuletByOperateTwoNum(23, 5, OperateType.Subtract)));


            Console.ReadKey();

            Environment.Exit(0);
            GC.Collect(0);

        }
    }
}
