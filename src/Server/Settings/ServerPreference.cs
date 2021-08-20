using System.Linq;
using ProjectServices.Shared.Constants.Localization;
using ProjectServices.Shared.Settings;

namespace ProjectServices.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}