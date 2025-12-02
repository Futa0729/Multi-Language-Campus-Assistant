using System;
using CampusAssistant.Models;
using CampusAssistant.Services;

namespace CampusAssistant.UI
{
    public class LanguageUI
    {
        private readonly LanguageService _languageService;

        public LanguageUI(LanguageService languageService)
        {
            _languageService = languageService;
        }

        public void SwitchLanguage()
        {
            if (_languageService.CurrentLanguage == Language.English)
            {
                Console.WriteLine("Select Language:");
                Console.WriteLine("1. English");
                Console.WriteLine("2. Japanese");
            }
            else if (_languageService.CurrentLanguage == Language.Japanese)
            {
                Console.WriteLine("言語を選択してください:");
                Console.WriteLine("1. 英語");
                Console.WriteLine("2. 日本語");
            }

            var languageChoice = Console.ReadLine();
            switch (languageChoice)
            {
                case "1":
                    _languageService.SetLanguage(Language.English);
                    Console.WriteLine("Language switched to English.");
                    break;
                case "2":
                    _languageService.SetLanguage(Language.Japanese);
                    Console.WriteLine("言語が日本語に切り替えられました。");
                    break;
                default:
                    if (_languageService.CurrentLanguage == Language.English)
                    {
                        Console.WriteLine("Invalid option. Press any key to continue...");
                    }
                    else if (_languageService.CurrentLanguage == Language.Japanese)
                    {
                        Console.WriteLine("無効なオプションです。続行するには任意のキーを押してください...");
                    }
                    Console.ReadLine();
                    break;
            }
        }
    }
}