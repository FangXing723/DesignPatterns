using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._1JDGCMS
{
    public class OperationDiv : Operation
    {
        /// <summary>
        /// 除法类
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            double result = OperationNum1 / OperationNum2;

            return result;
        }

    }
}
