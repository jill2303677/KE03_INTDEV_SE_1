using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace KE03_INTDEV_SE_1_Base.Pages
{
    public class OnderdelenModel : PageModel

    {
        public List<string> Bestellingen { get; set; } = new List<string>();
        public void OnGet()
        {
         
        }
        public void OnPost(string naam)
        {
            Bestellingen.Add(naam);
        }
        

    }
}
