using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment
{
    internal class GuestUser : User
    {
        public GuestUser(string? name) : base(name)
        {
        }

        public override Discount GetDiscount()
        {
            return null;
        }
    }
}
