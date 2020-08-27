using ActivityPub.Net.ObjectAndLinkTypes;
using Newtonsoft.Json;

namespace ActivityPub.Net.ActorTypes
{
    public class Person : SerializableObject
    {
        public Person()
        {
            Context = "https://www.w3.org/ns/activitystreams";
            Type = "Person";
        }
        [JsonProperty("@context")]
        public string Context { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("preferredUsername")]
        public string PreferredUsername { get; set; }
        [JsonProperty("summary")]
        public string Summary { get; set; }
        [JsonProperty("inbox")]
        public string Inbox { get; set; }
        [JsonProperty("outbox")]
        public string Outbox { get; set; }
        [JsonProperty("followers")]
        public string Followers { get; set; }
        [JsonProperty("following")]
        public string Following { get; set; }
        [JsonProperty("liked")]
        public string Liked { get; set; }

    }
}