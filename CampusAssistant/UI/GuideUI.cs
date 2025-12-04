using System;
using CampusAssistant.Models;
using CampusAssistant.Services;
using CampusAssistant.DataLayer;

namespace CampusAssistant.UI
{
    public class GuideUI
    {
        private LanguageService _languageService;
        public GuideUI(LanguageService languageService)
        {
            _languageService = languageService;
        }

        public void ShowGuides()
        {
            List<Guide> guides = GuideStore.GetAllGuides();

            if (_languageService.CurrentLanguage == Language.English)
            {
                Console.WriteLine("Campus Guides:");
            }
            else if (_languageService.CurrentLanguage == Language.Japanese)
            {
                Console.WriteLine("キャンパスガイド:");
            }

            foreach (Guide guide in guides)
            {
                string title = "";
                string steps = "";

                if (_languageService.CurrentLanguage == Language.English)
                {
                    title = guide.TitleEn;
                    steps = string.Join("\n", guide.StepsEn);
                }
                else if (_languageService.CurrentLanguage == Language.Japanese)
                {
                    title = guide.TitleJp;
                    steps = string.Join("\n", guide.StepsJp);
                }

                Console.WriteLine($"- {title}");
                Console.WriteLine(steps);
            }

            if (_languageService.CurrentLanguage == Language.English)
            {
                Console.WriteLine("Press any key to return to menu.");
            }
            else if (_languageService.CurrentLanguage == Language.Japanese)
            {
                Console.WriteLine("メニューに戻るには任意のキーを押してください。");
            }
            Console.ReadLine();
        }
    }
}