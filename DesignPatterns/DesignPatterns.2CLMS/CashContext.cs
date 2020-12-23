using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns._2CLMS.CashTypeEnum;

namespace DesignPatterns._2CLMS
{

    /// <summary>
    /// 策略模式上下文类
    /// 用于整合各类算法，是客户端与相应类的中间桥梁
    /// </summary>
    public class CashContext
    {
        CashSuper cs = null;

        public CashContext(CashType type)
        {
            switch (type)
            {
                case CashType.正常收费:
                    CashNormal cs0 = new CashNormal();
                    cs = cs0;
                    break;
                case CashType.八折:
                    CashRebate cs1 = new CashRebate(0.8);
                    cs = cs1;
                    break;
                case CashType.满400减100:
                    CashReturn cs2 = new CashReturn(400, 100);
                    cs = cs2;
                    break;
            }
        }

        /// <summary>
        /// 获取相应折扣后收费金额
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }


    }
}
