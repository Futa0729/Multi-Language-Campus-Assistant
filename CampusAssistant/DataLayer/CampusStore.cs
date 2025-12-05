using CampusAssistant.Models;

namespace CampusAssistant.DataLayer
{
    public static class CampusStore
    {
        private static List<CampusBuilding> buildings = new()
        {
            new CampusBuilding
            {
                NameEn = "Greenwood Student Center (GSC)",
                NameJp = "グリーンウッド学生センター (GSC)",
                DescriptionEn = "A facility for student activities, services, and socializing.",
                DescriptionJp = "学生の活動、サービス、交流の中心地。"
            },
            new CampusBuilding
            {
                NameEn = "Lucy Phillips Building (Testing Center)",
                NameJp = "ルーシー・フィリップス・ビルディング (テストセンター)",
                DescriptionEn = "A facility where students can take exams and assessments.",
                DescriptionJp = "学生が試験や評価を受ける施設。"
            },
            new CampusBuilding
            {
                NameEn = "Graham Science Center (GRSC)",
                NameJp = "グラハムサイエンスビルディング (GRSC)",
                DescriptionEn = "A facility where math or science classes and labs are held.",
                DescriptionJp = "数学や科学の授業と実験が行われる施設。"
            },
            new CampusBuilding
            {
                NameEn = "Humanities (HUMAN)",
                NameJp = "ヒューマニティー (GRSC)",
                DescriptionEn = "A facility where general or ESL classes are held.",
                DescriptionJp = "一般教養やESLの授業が行われる施設。"
            },
            new CampusBuilding
            {
                NameEn = "Noyes (NOYES)",
                NameJp = "ノイズ(GRSC)",
                DescriptionEn = "The administrative building including supporting a diverse range of programs",
                DescriptionJp = "多様なプログラムを支援する管理ビルディング。"
            },
            new CampusBuilding
            {
                NameEn = "Suites at Academy Square",
                NameJp = "スイーツ",
                DescriptionEn = "A residence hall for students.",
                DescriptionJp = "学生のためのレジデンスホール。"
            },
            
        };

        public static List<CampusBuilding> GetAllBuildings()
        {
            return buildings;
        }

    }
}