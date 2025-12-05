using System;
using CampusAssistant.Models;
using CampusAssistant.Services;
using CampusAssistant.UI;
using System.Collections.Generic;

namespace CampusAssistant.UI
{
    public class CommunityBoardUI
    {
        private readonly CommunityBoardService _communityBoardService;
        private readonly LanguageService _languageService;

        public CommunityBoardUI(LanguageService languageService, CommunityBoardService communityBoardService)
        {
            _languageService = languageService;
            _communityBoardService = communityBoardService;
        }

        public void ShowBoard()
        {
            Console.Clear();

            List<CommunityBoard> posts = _communityBoardService.GetAllPosts();
            if (_languageService.CurrentLanguage == Language.English)
            {
                Console.WriteLine("=== Community Board ===");
            }
            else
            {
                Console.WriteLine("=== 掲示板 ===");
            }

            if (posts.Count == 0)
            {
                if (_languageService.CurrentLanguage == Language.English)
                {
                    Console.WriteLine("No posts yet.");
                }
                else
                {
                    Console.WriteLine("投稿はまだありません。");
                }
            }
            else
            {
                foreach (CommunityBoard post in posts)
                {
                    if (_languageService.CurrentLanguage == Language.English)
                    {
                        Console.WriteLine("---------------");
                        Console.WriteLine("Title: " + post.Title);
                        Console.WriteLine("Author: " + post.Author);
                        Console.WriteLine("Content: " + post.Content);
                    }
                    else if (_languageService.CurrentLanguage == Language.Japanese)
                    {
                        Console.WriteLine("---------------");
                        Console.WriteLine("タイトル: " + post.Title);
                        Console.WriteLine("著者: " + post.Author);
                        Console.WriteLine("内容: " + post.Content);
                    }
                }
            }
            if (_languageService.CurrentLanguage == Language.English)
            {
                Console.WriteLine();
                Console.Write("Create new post? (y/n): ");
            }
            else
            {
                Console.WriteLine();
                Console.Write("新しく投稿しますか？ (y/n): ");
            }

            string answer = Console.ReadLine() ?? "";

            if (answer.ToLower() == "y")
            {
                CreatePost();
            }
        }

        public void CreatePost()
        {
            if (_languageService.CurrentLanguage == Language.English)
            {
                Console.Clear();
                Console.WriteLine("=== Create New Post ===");
                Console.Write("Enter post title: ");
            }
            else if (_languageService.CurrentLanguage == Language.Japanese)
            {
                Console.Clear();
                Console.WriteLine("=== 新しい投稿を作成 ===");
                Console.Write("投稿のタイトルを入力してください: ");
            }
            string title = Console.ReadLine();

            if (_languageService.CurrentLanguage == Language.English)
            {
                Console.Write("Enter your name: ");
            }
            else if (_languageService.CurrentLanguage == Language.Japanese)
            {
                Console.Write("あなたの名前を入力してください: ");
            }
            string author = Console.ReadLine();

            if (_languageService.CurrentLanguage == Language.English)
            {
                Console.Write("Enter post content: ");
            }
            else if (_languageService.CurrentLanguage == Language.Japanese)
            {
                Console.Write("投稿内容を入力してください: ");
            }
            string content = Console.ReadLine();

            CommunityBoard newPost = new CommunityBoard
            {
                Title = title,
                Author = author,
                Content = content
            };

            _communityBoardService.AddPost(newPost);

            if (_languageService.CurrentLanguage == Language.English)
            {
                Console.WriteLine("Post created successfully! Press any key to return to menu.");
            }
            else if (_languageService.CurrentLanguage == Language.Japanese)
            {
                Console.WriteLine("投稿が正常に作成されました！メニューに戻るには任意のキーを押してください。");
            }
            Console.ReadLine();
        }
    }
    
}