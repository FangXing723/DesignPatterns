using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2CLMS
{
    /// <summary>
    /// 满减收费类
    /// </summary>
    public class CashReturn : CashSuper
    {
        private double _moneyCondition = 0.0d;

        private double _moneyReturn = 0.0d;

        /// <summary>
        /// 满减收费构造函数
        /// </summary>
        /// <param name="moneyCondition">满减条件金额</param>
        /// <param name="moneyReturn">满减金额</param>
        public CashReturn(double moneyCondition, double moneyReturn)
        {
            _moneyCondition = moneyCondition;

            _moneyReturn = moneyReturn;
        }


        public override double AcceptCash(double money)
        {
            if (money >= _moneyCondition)
            {
                money = money - _moneyReturn;
            }

            return money;
        }
    }
}
