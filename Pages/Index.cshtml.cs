using Decker.Model;
using Decker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Decker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly CardService cardService;

        public List<PromptCard> Cards { get; set; }


        public IndexModel(ILogger<IndexModel> logger, CardService cardService)
        {
            _logger = logger;
            this.cardService = cardService;
        }

        public IActionResult OnGet(string? card)
        {
            if(!string.IsNullOrWhiteSpace(card))
            {
                return RedirectToPage("/Card", new { id = card });
            }
            _logger.Log(LogLevel.Information, "Index page visited");
            Cards = cardService.GetCards();
            return Page();
        }
    }
}
