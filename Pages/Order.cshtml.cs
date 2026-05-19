using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KE03_INTDEV_SE_1_Base.Pages
{
    public class OrderModel : PageModel
    {
        public List<string> Orders = OnderdelenModel.Orders;
        public void OnGet()
        {
        }
    }
}
