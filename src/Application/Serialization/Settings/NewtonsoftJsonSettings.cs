
using ProjectServices.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace ProjectServices.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}