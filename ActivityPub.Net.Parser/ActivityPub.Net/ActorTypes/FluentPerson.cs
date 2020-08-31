using System.Text;
using ActivityPub.Net.CoreTypes;
using ActivityPub.Net.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ActivityPub.Net.ActorTypes
{
    public class FluentPerson : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;
        private readonly Person _person;

        JObject _personObject = new JObject();

        public FluentPerson(ActivityStream parent, Person person) : base(parent)
        {
            _parent = parent;
            _person = person;
            _personObject.Add("@context", "https://www.w3.org/ns/activitystreams");
            _person.Context = "https://www.w3.org/ns/activitystreams";
            _personObject.Add("type", "Person");
            _person.Type = "Person";

        }

        public new FluentPerson Id(string id)
        {
            if (_personObject.ContainsKey("id")) _personObject.Remove("id");
            _personObject.Add("id", id);
            _person.Id = id;
            return this;
        }

        public FluentPerson CustomType(string type)
        {
            if (_personObject.ContainsKey("type")) _personObject.Remove("type");
            _personObject.Add("type", type);
            _person.Type = type;
            return this;
        }

        public FluentPerson Following(string following)
        {
            if (_personObject.ContainsKey("following")) _personObject.Remove("following");
            _personObject.Add("following", following);
            _person.Following = following;
            return this;
        }

        public FluentPerson Followers(string followers)
        {
            if (_personObject.ContainsKey("followers")) _personObject.Remove("followers");
            _personObject.Add("followers", followers);
            _person.Followers = followers;

            return this;
        }

        public FluentPerson Inbox(string inbox)
        {
            if (_personObject.ContainsKey("inbox")) _personObject.Remove("inbox");
            _personObject.Add("inbox", inbox);
            _person.Inbox = inbox;
            return this;
        }

        public FluentPerson OutBox(string outbox)
        {
            if (_personObject.ContainsKey("outbox")) _personObject.Remove("outbox");
            _personObject.Add("outbox", outbox);
            _person.Outbox = outbox;
            return this;
        }

        public FluentPerson PreferredUsername(string preferredUsername)
        {
            if (_personObject.ContainsKey("preferredUsername")) _personObject.Remove("preferredUsername");
            _personObject.Add("preferredUsername", preferredUsername);
            _person.PreferredUsername = preferredUsername;
            return this;
        }

        public new FluentPerson Name(string name)
        {
            if (_personObject.ContainsKey("name")) _personObject.Remove("name");
            _personObject.Add("name", name);
            _person.Name = name;
            return this;
        }

        public new FluentPerson Summary(string summary)
        {
            if (_personObject.ContainsKey("summary")) _personObject.Remove("summary");
            _personObject.Add("summary", summary);
            _person.Summary = summary;
            return this;
        }

        public FluentPerson Liked(string liked)
        {
            if (_personObject.ContainsKey("liked")) _personObject.Remove("liked");
            _personObject.Add("liked", liked);
            _person.Liked = liked;
            return this;
        }

        public ActivityStream EndPerson()
        {
            return _parent;
        }

        //public Person GetPerson()
        //{
        //    return _person;
        //}

        public dynamic GetObject()
        {
            return _personObject;
        }

        internal override string GetJsonBuild()
        {
            return JsonConvert.SerializeObject(_personObject);
        }



        //Icon

    }
}