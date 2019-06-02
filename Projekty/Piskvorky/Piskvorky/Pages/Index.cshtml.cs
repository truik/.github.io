using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Piskvorky.Data;

namespace Piskvorky.Pages
{
    public class IndexModel : PageModel
    {
        public Name _name { get; set; }
        public Pole _X { get; set; }
        public IndexModel( Name name, Pole pole) { _name = name; _X = pole;  }
        public void OnGet()
        {
        }
        public class Input
        {
            [Required]
            [Display(Name ="Vaše Jméno je")]
            public string Text { get; set; }
        }
        [BindProperty]
        public Input _Input { get; set; }
        
        public IActionResult OnPostAsync()
        {
            _name._Name = _Input.Text;

            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Redirect("./Game");
        }
    }
}