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
        private readonly CampusBuildingUI _campusBuildingUI;
        private readonly GuideUI _guideUI;
        private readonly SafetyUI _safetyUI;
        private readonly FavoriteTermUI _favoriteTermUI;
        private readonly CommunityBoardUI _communityBoardUI;



        public Menu(LanguageService languageService, FavoriteTermService favoriteService, CommunityBoardService communityBoardService)
        {
            _languageService = languageService;
            _languageUI = new LanguageUI(_languageService);
            _termUI = new TermUI(_languageService, favoriteService);
            _campusBuildingUI = new CampusBuildingUI(_languageService);
            _guideUI = new GuideUI(languageService);
            _safetyUI = new SafetyUI(_languageService);
            _favoriteTermUI = new FavoriteTermUI(_languageService, favoriteService);
            _communityBoardUI = new CommunityBoardUI(_languageService, communityBoardService);
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
                    Console.WriteLine("4. View Guides");
                    Console.WriteLine("5. Safety Information");
                    Console.WriteLine("6. Favorite Terms");
                    Console.WriteLine("7. Community Board");
                    Console.WriteLine("8. Exit");
                    Console.Write("Select an option: ");
                }
                else if (_languageService.CurrentLanguage == Language.Japanese)
                {
                    Console.WriteLine("1. 用語を見る");
                    Console.WriteLine("2. キャンパスの建物を見る");
                    Console.WriteLine("3. 言語を変更する");
                    Console.WriteLine("4. ガイドを見る");
                    Console.WriteLine("5. 安全情報");
                    Console.WriteLine("6. お気に入りの用語");
                    Console.WriteLine("7. 掲示板");
                    Console.WriteLine("8. 終了する");
                    Console.Write("オプションを選択してください: ");
                }

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _termUI.SearchTerms();
                        break;
                    case "2":
                        _campusBuildingUI.ShowCampusBuildings();
                        break;
                    case "3":
                        _languageUI.SwitchLanguage();
                        break;
                    case "4":
                        _guideUI.ShowGuides();
                        break;
                    case "5":
                        _safetyUI.ShowSafetyInfo();
                        break;
                    case "6":
                        _favoriteTermUI.ShowFavorites();
                        break;
                    case "7":
                        _communityBoardUI.ShowBoard();
                        break;
                    case "8":
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