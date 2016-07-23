using Newtonsoft.Json;

namespace Arke.Salesforce.Common.Models
{
    public class SuccessResponse
    {
        [JsonProperty(PropertyName = "id")]
        public string Id;

        [JsonProperty(PropertyName = "success")]
        public bool Success;

        [JsonProperty(PropertyName = "errors")]
        public object Errors;
    }
}

