using System;
using CampusAssistant.DataLayer;
using CampusAssistant.Models;
using CampusAssistant.Services;

namespace CampusAssistant.UI
{
    public class TermUI
    {
        private readonly LanguageService _languageService;
        private readonly FavoriteTermService _favoriteService;

        public TermUI(LanguageService languageService, FavoriteTermService favoriteService)
        {
            _languageService = languageService;
            _favoriteService = favoriteService;
        }

        public void SearchTerms()
        {
            if (_languageService.CurrentLanguage == Language.English)
            {
                Console.WriteLine("=== Term Search ===");
                Console.Write("Enter term to search: ");
            }
            else if (_languageService.CurrentLanguage == Language.Japanese)
            {
                Console.WriteLine("=== 用語検索 ===");
                Console.Write("検索する用語を入力してください: ");
            }

            string searchTerm = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                if (_languageService.CurrentLanguage == Language.English)
                {
                    Console.WriteLine("No term entered. Press any key to return to menu.");
                }
                else if (_languageService.CurrentLanguage == Language.Japanese)
                {
                    Console.WriteLine("用語が入力されていません。メニューに戻るには任意のキーを押してください。");
                }
                Console.ReadLine();
                return;
            }

            List<Term> terms = TermStore.GetAllTerms();

            string lowerSearchTerm = searchTerm.ToLower();
            bool found = false;

            foreach (Term term in terms)
            {
                string englishLower = term.English.ToLower();
                string japaneseLower = term.Japanese.ToLower();

                bool englishMatch = englishLower.Contains(lowerSearchTerm);
                bool japaneseMatch = japaneseLower.Contains(lowerSearchTerm);

                if (englishMatch || japaneseMatch)
                {
                    found = true;
                    if (_languageService.CurrentLanguage == Language.English)
                    {
                        Console.WriteLine($"Term: {term.English} ({term.Japanese})");
                        Console.WriteLine($"Definition: {term.EnglishDefinition}");
                        Console.WriteLine("Add to favorites? (y/n): ");
                    }
                    else if (_languageService.CurrentLanguage == Language.Japanese)
                    {
                        Console.WriteLine($"用語: {term.Japanese} ({term.English})");
                        Console.WriteLine($"定義: {term.JapaneseDefinition}");
                        Console.WriteLine("お気に入りに追加しますか？ (y/n): ");
                    }

                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "y")
                    {
                        _favoriteService.AddFavorite(term);

                        
                        if (_languageService.CurrentLanguage == Language.English)
                        {
                            Console.WriteLine("Term added to favorites.");
                        }
                        else if (_languageService.CurrentLanguage == Language.Japanese)
                        {
                            Console.WriteLine("用語がお気に入りに追加されました。");
                        }
                        Console.ReadLine();
                    }
                }

                

                if (!found)
                {
                    if (_languageService.CurrentLanguage == Language.English)
                    {
                        Console.WriteLine("No matching terms found. Press any key to return to menu.");
                    }
                    else if (_languageService.CurrentLanguage == Language.Japanese)
                    {
                        Console.WriteLine("一致する用語が見つかりません。メニューに戻るには任意のキーを押してください。");
                    }
                    Console.ReadLine();
                }
            }
            

        }
    }
}