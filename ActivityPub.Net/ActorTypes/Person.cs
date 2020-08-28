using ActivityPub.Net.ObjectAndLinkTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ActivityPub.Net.ActorTypes
{
    public class Person 
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

    public class Person2 : SerializableObject
    {
        JObject _person = new JObject();
        public Person2()
        {
            _person.Add("@context", "https://www.w3.org/ns/activitystreams");
            _person.Add("type", "Person");
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