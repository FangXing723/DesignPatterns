using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2CLMS
{
  public static  class CashTypeEnum
    {
        /// <summary>
        /// 收费类型
        /// </summary>
        public enum CashType
        {
            正常收费,
            八折,
            满400减100,
        }
    }
}
