using System;
using CampusAssistant.Models;
using CampusAssistant.Services;
using CampusAssistant.DataLayer;


namespace CampusAssistant.UI
{
    public class CampusBuildingUI
    {
        private readonly LanguageService _languageService;
        public CampusBuildingUI(LanguageService languageService)
        {
            _languageService = languageService;
        }

        public void ShowCampusBuildings()
        {
            Console.Clear();

            List<CampusBuilding> buildings = CampusStore.GetAllBuildings();

            if (_languageService.CurrentLanguage == Language.English)
            {
                Console.WriteLine("Campus Buildings:");
            }
            else if (_languageService.CurrentLanguage == Language.Japanese)
            {
                Console.WriteLine("キャンパスの建物:");
            }


            foreach (CampusBuilding building in buildings)
            {
                string name = "";
                string description = "";

                if (_languageService.CurrentLanguage == Language.English)
                {
                    name = building.NameEn;
                    description = building.DescriptionEn;
                }
                else if (_languageService.CurrentLanguage == Language.Japanese)
                {
                    name = building.NameJp;
                    description = building.DescriptionJp;
                }

                Console.WriteLine($"- {name}: {description}");
                Console.WriteLine();
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