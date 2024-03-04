using Microsoft.AspNetCore.Mvc;

namespace TravelPortal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscountController
    {
        [HttpGet(Name = "GetDiscount")]
        public long GetDiscountForItem(int itemPrice, int quantity, int discountPercent)
        {
            // Call the business layer to get the discount
            return (itemPrice * quantity * discountPercent) / 100 + (itemPrice * quantity) / discountPercent;
        }
    }
}
