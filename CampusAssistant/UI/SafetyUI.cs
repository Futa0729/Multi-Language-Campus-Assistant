using CampusAssistant.Models;
using CampusAssistant.Services;

namespace CampusAssistant.UI
{
    public class SafetyUI
    {
        private readonly LanguageService _languageService;

        public SafetyUI(LanguageService languageService)
        {
            _languageService = languageService;
        }

        public void ShowSafetyInfo()
        {
            if (_languageService.CurrentLanguage == Language.English)
            {
                Console.WriteLine("=== Campus Safety Information ===");
                Console.WriteLine();
                Console.WriteLine("For Emergencies:");
                Console.WriteLine("Call 9-1-1");
                Console.WriteLine();
                Console.WriteLine("For Non-Emergencies");
                Console.WriteLine("Call 435.835.2345");
            }
            else if (_languageService.CurrentLanguage == Language.Japanese)
            {
                Console.WriteLine("=== キャンパスの安全情報 ===");
                Console.WriteLine();
                Console.WriteLine("緊急の場合：");
                Console.WriteLine("9-1-1に電話してください");
                Console.WriteLine();
                Console.WriteLine("緊急でない場合：");
                Console.WriteLine("435.835.2345に電話してください");
            }
        }
    }
}