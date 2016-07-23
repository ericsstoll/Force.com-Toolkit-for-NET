using Newtonsoft.Json;

namespace Arke.Salesforce.Chatter.Models
{
    public class GroupInformation
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
    }
}
