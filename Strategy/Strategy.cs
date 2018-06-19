using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class Invoice
    {
        double tot;
        NetPayable calc;

        public NetPayable NetPayableCalculator
        {
            set { this.calc = value; }
        }

        public double GrossAmmount
        {
            set 
            { 
                this.tot = value; 
            }
            get 
            { 
                return this.tot; 
            }
        }

        public double NetAmount
        {
            get 
            {
                if (this.calc != null)
                {
                    return this.calc.CalculateTotal(this);
                }
                else
                {
                    throw new Exception("NetPayableCalculator is not assigned");
                }
            }
        }
    }

    public abstract class NetPayable
    {
        abstract public double CalculateTotal(Invoice inv);
    }

    class LocalPayable : NetPayable
    {
        public override double CalculateTotal(Invoice inv)
        {
            return inv.GrossAmmount + 0.04 * inv.GrossAmmount;
        }
    }

    class IntlPayable : NetPayable
    {
        public override double CalculateTotal(Invoice inv)
        {
            return inv.GrossAmmount + 0.10 * inv.GrossAmmount;
        }
    }

}
