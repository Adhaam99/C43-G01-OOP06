using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment
{
    internal class BuyOneGetOneDiscount : Discount
    {

        public BuyOneGetOneDiscount() : base("Buy one get one") { }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return (price / 2 ) * (quantity/2);
        }
    }
}
