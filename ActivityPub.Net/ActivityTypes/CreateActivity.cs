using System.Collections.Generic;
using ActivityPub.Net.CoreTypes;
using ActivityPub.Net.ObjectAndLinkTypes;
using Newtonsoft.Json;

namespace ActivityPub.Net.ActivityTypes
{
    public class CreateActivity 
    {
        public CreateActivity()
        {
            Context = "https://www.w3.org/ns/activitystreams";
            Type = "Create";
        }
        [JsonProperty("@context")]
        public string Context { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("to")]
        public IList<string> To { get; set; }
        [JsonProperty("actor")]
        public string Actor { get; set; }
        [JsonProperty("object")]
        public string Object { get; set; }
    }
    public class FluentCreateActivity : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;
        CreateActivity _createActivity;
        private FluentNote _fluentNote;

        public FluentCreateActivity(ActivityStream parent) : base(parent)
        {
            _parent = parent;
            _createActivity = new CreateActivity();
        }
        public new FluentCreateActivity Id(string id)
        {
            return this;
        }

        public FluentCreateActivity To(string to)
        {
            _createActivity.To.Add(to);
            return this;
        }

        public FluentCreateActivity Actor(string actor)
        {
            _createActivity.Actor = actor;
            return this;
        }

        public FluentCreateActivity Object(object objectActivity)
        {
            //_createActivity.Object = actor;
            return this;
        }

        public FluentNote ObjectNote()
        {
            return _fluentNote ?? (_fluentNote = new FluentNote(_parent));
        }

        protected CreateActivity GetCreateActivity()
        {
            return _createActivity;
        }


    }
}