using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ActivityPub.Net.CoreTypes
{
    public class Link 
    {

        internal Link(ActivityStream activityStream)
        {
            Context = "https://www.w3.org/ns/activitystreams";
            Type = "Link";

        }

        [JsonProperty("@context")]
        public string Context { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("to")]
        public IList<string> To { get; set; }
        [JsonProperty("attributedTo")]
        public string AttributedTo { get; set; }
        [JsonProperty("content")]
        public string Content { get; set; }
        [JsonProperty("actor")]
        public string Actor { get; set; }
    }
}
