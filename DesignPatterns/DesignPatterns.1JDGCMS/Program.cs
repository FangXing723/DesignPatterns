using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._1JDGCMS
{
    /// <summary>
    /// 设计模式：简单工厂模式
    /// 用例情况：计算器
    /// Operation：运算的基类，具有运算数1、运算数2以及（虚）返回结果方法
    /// Operation+Type：运算基类的派生类，例如加减乘除等
    /// OperationFactory：工厂类，利用多态特性，根据运算符作为判断的依据，将运算基类实例化成不同的运算类
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {

            Operation operation;


            operation = OperationFactory.CreateOperation("+");
            operation.OperationNum1 = 20.0;
            operation.OperationNum2 = 4.0;
            Console.WriteLine(operation.GetResult());

            operation = OperationFactory.CreateOperation("-");
            operation.OperationNum1 = 20.0;
            operation.OperationNum2 = 4.0;
            Console.WriteLine(operation.GetResult());

            operation = OperationFactory.CreateOperation("*");
            operation.OperationNum1 = 20.0;
            operation.OperationNum2 = 4.0;
            Console.WriteLine(operation.GetResult());

            operation = OperationFactory.CreateOperation("/");
            operation.OperationNum1 = 20.0;
            operation.OperationNum2 = 4.0;
            Console.WriteLine(operation.GetResult());



            Console.ReadKey();
            Environment.Exit(0);
            GC.Collect(0);
        }
    }
}
