using System.Dynamic;
using ActivityPub.Net.CoreTypes;
using Newtonsoft.Json;

namespace ActivityPub.Net.ActorTypes
{
    public class Person 
    {
        private readonly FluentPerson _fluentPerson;

        internal Person(ActivityStream parent)
        {
            _fluentPerson = new FluentPerson(parent, this);
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

        internal FluentPerson FluentPerson()
        {
            return _fluentPerson;
        }


    }

    //public class Person2 : SerializableObject
    //{
    //    JObject _person = new JObject();
    //    public Person2()
    //    {
    //        _person.Add("@context", "https://www.w3.org/ns/activitystreams");
    //        _person.Add("type", "Person");
    //    }
    //    [JsonProperty("@context")]
    //    public string Context { get; set; }
    //    [JsonProperty("id")]
    //    public string Id { get; set; }
    //    [JsonProperty("type")]
    //    public string Type { get; set; }
    //    [JsonProperty("name")]
    //    public string Name { get; set; }
    //    [JsonProperty("preferredUsername")]
    //    public string PreferredUsername { get; set; }
    //    [JsonProperty("summary")]
    //    public string Summary { get; set; }
    //    [JsonProperty("inbox")]
    //    public string Inbox { get; set; }
    //    [JsonProperty("outbox")]
    //    public string Outbox { get; set; }
    //    [JsonProperty("followers")]
    //    public string Followers { get; set; }
    //    [JsonProperty("following")]
    //    public string Following { get; set; }
    //    [JsonProperty("liked")]
    //    public string Liked { get; set; }

    //}

}