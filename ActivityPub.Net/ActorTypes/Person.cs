using System.Dynamic;
using ActivityPub.Net.CoreTypes;
using ActivityPub.Net.ObjectAndLinkTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ActivityPub.Net.ActorTypes
{
    public class Person 
    {
        private ActivityStream _parent;
        private FluentPerson _fluentPerson;

        public Person()
        {
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

        public dynamic GetObject()
        {
            if (_fluentPerson != null) return _fluentPerson.GetObject();
            return new ExpandoObject();
        }


        public string GetBuild()
        {
            if (_fluentPerson != null) return _fluentPerson.GetJsonBuild();
            return "{}";
        }

        internal FluentPerson InitFluent(ActivityStream parent)
        {
            _parent = parent;
            _fluentPerson = new FluentPerson(parent, this);
            return _fluentPerson;
        }


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