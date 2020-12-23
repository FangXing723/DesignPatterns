using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._1JDGCMS
{
    public class OperationFactory
    {

        /// <summary>
        /// 创建运算类
        /// </summary>
        /// <param name="operationType"></param>
        /// <returns></returns>
        public static Operation CreateOperation(string operationType)
        {
            Operation operation = null;

            switch(operationType)
            {
                case "+":
                    operation = new OperationAdd();
                    break;
                case "-":
                    operation = new OperationSub();
                    break;
                case "*":
                    operation = new OperationMul();
                    break;
                case "/":
                    operation = new OperationDiv();
                    break;
            }

            return operation;

        }



    }
}
