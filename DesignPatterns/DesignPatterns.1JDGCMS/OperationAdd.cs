﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._1JDGCMS
{
    /// <summary>
    /// 加法类
    /// </summary>
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = OperationNum1 + OperationNum2;

            return result;
        }
    }
}
