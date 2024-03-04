using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPortal.Business
{
    public class DiscountBusiness
    {
        public long GetDiscountForItem(int itemPrice, int quantity, int discountPercent)
        {
            return (itemPrice * quantity * discountPercent) / 100 + (itemPrice * quantity)/discountPercent;
        }
    }
}
