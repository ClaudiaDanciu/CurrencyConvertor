using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorTheFirst.Pages
{
    public class InputNameModel : PageModel
    { 
        public string name;
        public void OnPost()
            {
                this.name = Convert.ToString(Request.Form["amount"]);
            }
    }
}
    

