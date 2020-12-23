using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._1JDGCMS
{
    public class Operation
    {

        /// <summary>
        /// 前计算数
        /// </summary>
        public double OperationNum1 { get; set; }

        /// <summary>
        /// 后计算数
        /// </summary>
        public double OperationNum2 { get; set; }


        /// <summary>
        /// 获取计算结果
        /// </summary>
        /// <returns></returns>
        public virtual double GetResult()
        {
            return 9999;
        }

    }
}
