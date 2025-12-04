using CampusAssistant.Services;
using CampusAssistant.UI;

namespace CampusAssistant
{
    class Program
    {
        static void Main(string[] args)
        {
            LanguageService languageService = new LanguageService();
            FavoriteTermService favoriteService = new FavoriteTermService();            
            Menu menu = new Menu(languageService, favoriteService);
            menu.Run();
        }
    }
}