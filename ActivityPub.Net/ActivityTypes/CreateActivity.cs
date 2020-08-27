using System.Collections.Generic;
using ActivityPub.Net.CoreTypes;
using Newtonsoft.Json;

namespace ActivityPub.Net.ActivityTypes
{
    public class Activity : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;
        private FluentCreateActivity _fluentCreateActivity;

        public Activity(ActivityStream parent) : base(parent)
        {
            _parent = parent;
        }

        public FluentCreateActivity CreateActivity()
        {
            return _fluentCreateActivity ?? (_fluentCreateActivity = new FluentCreateActivity(_parent));
        }

        internal override string GetBuild()
        {
            var resultString = "";
            if (_fluentCreateActivity != null) resultString = _fluentCreateActivity.GetBuild();
            return resultString;
        }

    }

    public class CreateActivity 
    {
        public CreateActivity()
        {
            Context = "https://www.w3.org/ns/activitystreams";
            Type = "Create";
            To = new List<string>();
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
        public object Object { get; set; }
        [JsonIgnore]
        public string InternalObject { get; set; }
    }
}