using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorTheFirst.Pages
{
    public class CurrencyConvertModel : PageModel
    {
        public double amount;
        public const double rate = 1.14;
        public double currency;
        public void OnPost()
        {
            this.amount = Convert.ToDouble(Request.Form["amount"]);
            this.currency = amount * rate;
        }
    }
}
