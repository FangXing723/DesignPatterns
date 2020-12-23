using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._1JDGCMS
{
    /// <summary>
    /// 乘法类
    /// </summary>
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = OperationNum1 * OperationNum2;

            return result;

        }
    }
}
