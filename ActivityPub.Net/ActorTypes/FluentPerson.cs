using System.Text;
using ActivityPub.Net.CoreTypes;
using ActivityPub.Net.Enums;
using Newtonsoft.Json;

namespace ActivityPub.Net.ActorTypes
{
    public class FluentPerson : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;
        private Person _person;


        public FluentPerson(ActivityStream parent) : base(parent)
        {
            _parent = parent;
            _person = new Person();
        }

        public new FluentPerson Id(string id)
        {
            _person.Id = id;
            return this;
        }

        public FluentPerson CustomType(string type)
        {
            _person.Type = type;
            return this;
        }

        public FluentPerson Following(string following)
        {
            _person.Following = following;
            return this;
        }

        public FluentPerson Followers(string followers)
        {
            _person.Followers = followers;
            return this;
        }

        public FluentPerson Inbox(string inbox)
        {
            _person.Inbox = inbox;
            return this;
        }

        public FluentPerson OutBox(string outbox)
        {
            _person.Outbox = outbox;
            return this;
        }

        public FluentPerson PreferredUsername(string preferredUsername)
        {
            _person.PreferredUsername = preferredUsername;
            return this;
        }

        public new FluentPerson Name(string name)
        {
            _person.Name = name;
            return this;
        }

        public new FluentPerson Summary(string summary)
        {
            _person.Summary = summary;
            return this;
        }

        public FluentPerson Liked(string liked)
        {
            _person.Liked = liked;
            return this;
        }

        public ActivityStream EndPerson()
        {
            return _parent;
        }

        public Person GetPerson()
        {
            return _person;
        }

        internal override string GetBuild()
        {
            return JsonConvert.SerializeObject(_person);
        }



        //Icon

    }
}