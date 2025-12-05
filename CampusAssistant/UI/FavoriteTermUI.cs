using System;
using CampusAssistant.Services;
using CampusAssistant.Models;


namespace CampusAssistant.UI
{
    public class FavoriteTermUI
    {
        private readonly LanguageService _languageService;
        private readonly FavoriteTermService _favoriteTermService;

        public FavoriteTermUI(LanguageService languageService, FavoriteTermService favoriteTermService)
        {
            _languageService = languageService;
            _favoriteTermService = favoriteTermService;
        }

        public void ShowFavorites()
        {
            Console.Clear();
            
            List<Term> favorites = _favoriteTermService.GetFavorites();
            if (_languageService.CurrentLanguage == Language.English)
            {
                Console.WriteLine("=== Favorite Terms ===");
            }
            else
            {
                Console.WriteLine("=== お気に入り用語 ===");
            }

            if (favorites.Count == 0)
            {
                if (_languageService.CurrentLanguage == Language.English)
                {
                    Console.WriteLine("You do not have any favorite terms yet.");
                }
                else
                {
                    Console.WriteLine("お気に入りの用語はまだありません。");
                }

                Console.WriteLine("Press Enter to return to menu.");
                Console.ReadLine();
                return;
            }

            

            Console.WriteLine();

            foreach (Term term in favorites)
            {
                if (_languageService.CurrentLanguage == Language.English)
                {
                    Console.WriteLine("Term: " + term.English);
                    Console.WriteLine("Definition: " + term.EnglishDefinition);
                }
                else
                {
                    Console.WriteLine("用語: " + term.Japanese);
                    Console.WriteLine("定義: " + term.JapaneseDefinition);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Press Enter to return to menu.");
            Console.ReadLine();
        }
    }
}
