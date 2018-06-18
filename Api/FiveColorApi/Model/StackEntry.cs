using Newtonsoft.Json;
using System.Collections.Generic;

namespace FiveColorApi.Model
{
    public class StackEntry
    {
        [JsonProperty(PropertyName = "Card")]
        public Card Card { get; set; }
        [JsonProperty(PropertyName = "OwnerId")]
        public int OwnerId { get; set; }
        [JsonProperty(PropertyName = "Targets")]
        public List<Target> Targets { get; set; }
    }
}