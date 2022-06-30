using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.JavTube.Models;

public class ProviderModel
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("provider")]
    public string Provider { get; set; }

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }
}