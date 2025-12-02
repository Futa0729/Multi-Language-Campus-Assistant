using CampusAssistant.Models;

namespace CampusAssistant.DataLayer
{
    public static class TermStore
    {
        private static List<Term> terms = new()
        {
            new Term
            {
                English = "credit",
                Japanese = "単位",
                EnglishDefinition = "a unit that measures a course's academic work and tracks progress toward a degree.",
                JapaneseDefinition = "科目ごとの学習の基準量"
            },
            new Term
            {
                English = "syllabus",
                Japanese = "シラバス",
                EnglishDefinition = "a document that outlines expectations and schedule for a course.",
                JapaneseDefinition = "授業の内容、目的、評価方法などを詳しくまとめた授業計画書。"
            }
        };

        public static List<Term> GetAllTerms()
        {
            return terms;
        }
    }
}