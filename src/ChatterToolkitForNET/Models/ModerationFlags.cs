using Newtonsoft.Json;

namespace Arke.Salesforce.Chatter.Models
{
    public class ModerationFlags
    {
        [JsonProperty(PropertyName = "flagCount")]
        public int FlagCount { get; set; }

        [JsonProperty(PropertyName = "flaggedByMe")]
        public bool FlaggedByMe { get; set; }
    }
}