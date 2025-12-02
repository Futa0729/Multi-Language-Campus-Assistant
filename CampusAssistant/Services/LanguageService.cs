using CampusAssistant.Models;

namespace CampusAssistant.Services
{
    public class LanguageService
    {
        public Language CurrentLanguage { get; private set; } = Language.English;

        public void SetLanguage(Language language)
        {
            CurrentLanguage = language;
        }
    }
}