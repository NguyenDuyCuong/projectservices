using ProjectServices.Shared.Settings;
using System.Threading.Tasks;
using ProjectServices.Shared.Wrapper;

namespace ProjectServices.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}