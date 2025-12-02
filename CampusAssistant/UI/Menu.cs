using System;
using CampusAssistant.Models;
using CampusAssistant.Services;
using CampusAssistant.DataLayer;

namespace CampusAssistant.UI
{
    public class Menu
    {
        public readonly LanguageService _languageService;
        private readonly LanguageUI _languageUI;
        private readonly TermUI _termUI;

        public Menu(LanguageService languageService)
        {
            _languageService = languageService;
            _languageUI = new LanguageUI(_languageService);
            _termUI = new TermUI(_languageService);
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("===== Multi-Language Campus Assistant =====");
                Console.WriteLine("Current Language: " + _languageService.CurrentLanguage);
                Console.WriteLine("===========================================");

                if (_languageService.CurrentLanguage == Language.English)
                {
                    Console.WriteLine("1. View Terms");
                    Console.WriteLine("2. View Campus Buildings");
                    Console.WriteLine("3. Change Language");
                    Console.WriteLine("4. Exit");
                    Console.Write("Select an option: ");
                }
                else if (_languageService.CurrentLanguage == Language.Japanese)
                {
                    Console.WriteLine("1. 用語を見る");
                    Console.WriteLine("2. キャンパスの建物を見る");
                    Console.WriteLine("3. 言語を変更する");
                    Console.WriteLine("4. 終了する");
                    Console.Write("オプションを選択してください: ");
                }

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _termUI.SearchTerms();
                        break;
                    case "2":
                        // ShowCampusBuildings();
                        break;
                    case "3":
                        _languageUI.SwitchLanguage();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }



        
    }
}