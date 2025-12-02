using CampusAssistant.Services;
using CampusAssistant.UI;

namespace CampusAssistant
{
    class Program
    {
        static void Main(string[] args)
        {
            LanguageService languageService = new LanguageService();
            Menu menu = new Menu(languageService);
            menu.Run();
        }
    }
}