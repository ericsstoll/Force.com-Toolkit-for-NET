using Newtonsoft.Json;

namespace Arke.Salesforce.Chatter.Models
{
    public class ClientInfo
    {
        [JsonProperty(PropertyName = "applicationName")]
        public string ApplicationName { get; set; }

        [JsonProperty(PropertyName = "applicationUrl")]
        public string ApplicationUrl { get; set; }
    }
}