using Decker.Model;
using Decker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Decker.Pages
{
    public class CardModel : PageModel
    {
        private readonly CardService cardService;

        public PromptCard Card { get; set; }

        public CardModel(CardService cardService)
        {
            this.cardService = cardService;
        }
        public void OnGet(int id)
        {
            Card = cardService.GetCardById(id);

        }
    }
}
