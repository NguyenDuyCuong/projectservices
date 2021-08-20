using System.Text.Json;
using ProjectServices.Application.Interfaces.Serialization.Options;

namespace ProjectServices.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}