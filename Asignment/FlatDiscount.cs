using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment
{
    internal class FlatDiscount  : Discount
    {
        

        public int Amount { get; set; }

        public FlatDiscount(int amount) : base("Flat Discount")
        {
            Amount = amount;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return Amount *  Math.Min(quantity , 1);
        }
    }
}
