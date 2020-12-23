using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2CLMS
{
    /// <summary>
    /// 打折收费类
    /// </summary>
    public class CashRebate : CashSuper
    {
        private double _moneyRebate = 1d;

        public CashRebate(double moneyRebate)
        {
            _moneyRebate = moneyRebate;
        }


        public override double AcceptCash(double money)
        {
            return money * _moneyRebate;
        }
    }
}
