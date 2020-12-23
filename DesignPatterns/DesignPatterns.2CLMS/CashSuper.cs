using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2CLMS
{
    /// <summary>
    /// 收费抽象类
    /// </summary>
    public abstract class CashSuper
    {
        /// <summary>
        /// 收取现金
        /// </summary>
        /// <param name="money">现金数</param>
        /// <returns>现金数</returns>
        public abstract double AcceptCash(double money);
        
    }
}
