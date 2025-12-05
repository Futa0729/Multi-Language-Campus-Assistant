using CampusAssistant.Models;

namespace CampusAssistant.DataLayer
{
    public static class GuideStore
    {
        private static List<Guide> guides = new()
        {
            new Guide
            {
                TitleEn = "How to Register for Classes",
                TitleJp = "クラスの登録方法",
                StepsEn = new List<string>
                {
                    "1. Log in to the student portal on MySnow.",
                    "2. Go to the 'Course Registration'.",
                    "3. Select desired courses and add them to your schedule.",
                    "4. Confirm your registration."
                },
                StepsJp = new List<string>
                {
                    "1. MySnowの学生ポータルにログインします。",
                    "2. 'コース登録'セクションに移動します。",
                    "3. 希望するコースを選択してスケジュールに追加します。",
                    "4. 登録を確認します。"
                }
            },
            new Guide
            {
                TitleEn = "How to Check Your Grades",
                TitleJp = "成績の確認方法",
                StepsEn = new List<string>
                {
                    "1. Log in to your student portal on MySnow.",
                    "2. Go to the 'Graduation Progress'.",
                    "3. You can see your dgree progress there.",
                },
                StepsJp = new List<string>
                {
                    "1. MySnowの学生ポータルにログインします。",
                    "2. 'Graduation Progress'セクションに移動します。",
                    "3. そこで学位の進捗状況を確認できます。",
                }
            },
            new Guide
            {
                TitleEn = "How to Contact Your Professor",
                TitleJp = "先生への連絡方法",
                StepsEn = new List<string>
                {
                    "1. Check the inbox on syllabus.",
                    "2. Press 'Compose' to send the message.",
                    "3. Chose your course and name who you send message to.",
                    "4. Clearly explain your question or request.",
                },
                StepsJp = new List<string>
                {
                    "1. シラバスの受信箱を確認します。",
                    "2. 'Compose'を押してメッセージを送信します。",
                    "3. コースと送信先の名前を選択します。",
                    "4. 質問やリクエストを明確に説明します。",
                }
            }


        };
        public static List<Guide> GetAllGuides()
        {
            return guides;
        }
    }
}