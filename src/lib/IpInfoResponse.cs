using Newtonsoft.Json;

namespace MyApi
{
public class IpInfoResponse
{
    [JsonProperty(PropertyName="ip")]
    public string IP { get; set; }
    [JsonProperty(PropertyName="hostname")]
    public string Hostname { get; set; }
    [JsonProperty(PropertyName="city")]
    public string City { get; set; }
    [JsonProperty(PropertyName="region")]
    public string Region { get; set; }
    [JsonProperty(PropertyName="country")]
    public string Country { get; set; }
    public string loc { get; set; }
    public string org { get; set; }
    [JsonProperty(PropertyName="postal")]
    public string Postal { get; set; }
}
}