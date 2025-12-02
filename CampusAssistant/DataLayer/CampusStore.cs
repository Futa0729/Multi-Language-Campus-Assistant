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
                DescriptionEn = "A hub for student activities, services, and socializing.",
                DescriptionJp = "学生の活動、サービス、交流の中心地。"
            },
            new CampusBuilding
            {
                NameEn = "Lucy Phillips Building (Testing Center)",
                NameJp = "ルーシー・フィリップス・ビルディング (テストセンター)",
                DescriptionEn = "A facility where students can take exams and assessments.",
                DescriptionJp = "学生が試験や評価を受ける施設。"
            },
        };

        public static List<CampusBuilding> GetAllBuildings()
        {
            return buildings;
        }

    }
}