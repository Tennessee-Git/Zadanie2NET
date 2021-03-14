using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Zadanie2.net.Forms;

namespace Zadanie2.net.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Address Address { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        { }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
                return Page();
            else
                return RedirectToPage("./Privacy");
        }
    }
}
