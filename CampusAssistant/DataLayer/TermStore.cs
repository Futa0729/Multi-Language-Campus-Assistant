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
            },
            new Term
            {
                English = "major",
                Japanese = "専攻",
                EnglishDefinition = "the main field of study for a student's degree.",
                JapaneseDefinition = "学生が学位取得のために選ぶ主な学問分野。"
            },
            new Term
            {
                English = "minor",
                Japanese = "副専攻",
                EnglishDefinition = "a secondary field of study that complements a student's major.",
                JapaneseDefinition = "学生の専攻を補完する第二の学問分野。"
            },
            new Term
            {
                English = "GPA",
                Japanese = "GPA(平均成績点)",
                EnglishDefinition = "a numerical average of a student's grade, usually on a 4.0 scale.",
                JapaneseDefinition = "学生の成績の数値的な平均、通常は4.0スケールで表される。"
            },
            new Term
            {
                English = "lecture",
                Japanese = "講義",
                EnglishDefinition = "A class where the instructor presents material to students.",
                JapaneseDefinition = "講師が学生に資料を提示する授業。"
            },
            new Term
            {
                English = "lab",
                Japanese = "実験(ラボ)",
                EnglishDefinition = "A class focused on hands-on experiments and practical applications.",
                JapaneseDefinition = "実験と実践的な応用に焦点を当てた授業。"
            },
        };

        public static List<Term> GetAllTerms()
        {
            return terms;
        }
    }
}