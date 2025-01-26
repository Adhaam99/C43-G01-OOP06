using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment
{
    internal class PercentageDiscount : Discount
    {
       

        public int Percentage {  get; set; }

        public PercentageDiscount(int percentage):base("Percentage Discount")
        {
            Percentage = percentage;
        }

        public override decimal CalculateDiscount( decimal price , int quantity )
        {
            return price * quantity * (Percentage / 100M);
        }


    }
}
