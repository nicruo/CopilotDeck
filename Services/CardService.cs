using Decker.Model;
using System.Text.Json;

namespace Decker.Services
{
    public class CardService
    {
        private List<PromptCard> cards;

        public CardService()
        {
            var json = File.ReadAllText("cards.json");
            cards = JsonSerializer.Deserialize<List<PromptCard>>(json);
        }

        public List<PromptCard> GetCards()
        {
            //read cards from cards.json
            return cards;
        }

        public PromptCard GetCardById(int id)
        {
            return cards.FirstOrDefault(c => c.Id == id);
        }
    }
}
