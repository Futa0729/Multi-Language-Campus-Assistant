using CampusAssistant.Models;
using CampusAssistant.DataLayer;


namespace CampusAssistant.Services
{
    public class CommunityBoardService
    {
        private List<CommunityBoard> LoadAllPosts()
        {
            return Database.Load<CommunityBoard>();
        }

        private void SaveAllPosts(List<CommunityBoard> posts)
        {
            Database.Save(posts);
        }

        public void AddPost(CommunityBoard newPost)
        {
            List<CommunityBoard> allPosts = LoadAllPosts();

            allPosts.Add(newPost);

            SaveAllPosts(allPosts);
        }

        public List<CommunityBoard> GetAllPosts()
        {
            return LoadAllPosts();
        }
    }
}
