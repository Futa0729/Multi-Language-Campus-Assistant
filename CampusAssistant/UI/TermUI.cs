using System;
using CampusAssistant.DataLayer;
using CampusAssistant.Models;
using CampusAssistant.Services;

namespace CampusAssistant.UI
{
    public class TermUI
    {
        private readonly LanguageService _languageService;

        public TermUI(LanguageService languageService)
        {
            _languageService = languageService;
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
                    }
                    else if (_languageService.CurrentLanguage == Language.Japanese)
                    {
                        Console.WriteLine($"用語: {term.Japanese} ({term.English})");
                        Console.WriteLine($"定義: {term.JapaneseDefinition}");
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