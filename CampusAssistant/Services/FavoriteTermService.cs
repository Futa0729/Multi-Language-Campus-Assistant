using CampusAssistant.Models;
using CampusAssistant.DataLayer;


namespace CampusAssistant.Services
{
    public class FavoriteTermService
    {
        private List<Term> LoadAllTerms()
        {
            return Database.Load<Term>();
        }

        private void SaveAllTerms(List<Term> terms)
        {
            Database.Save(terms);
        }

        public void AddFavorite(Term target)
        {
            List<Term> allTerms = LoadAllTerms();

            foreach (Term term in allTerms)
            {
                if (term.English == target.English)
                {
                    term.IsFavorite = true;
                }
            }

            SaveAllTerms(allTerms);
        }

        public List<Term> GetFavorites()
        {
            List<Term> allTerms = LoadAllTerms();
            List<Term> favorites = new List<Term>();

            foreach (Term term in allTerms)
            {
                if (term.IsFavorite)
                {
                    favorites.Add(term);
                }
            }

            return favorites;
        }
    }
}