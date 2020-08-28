using System.Collections.Generic;
using System.Dynamic;
using ActivityPub.Net.CoreTypes;
using Newtonsoft.Json;

namespace ActivityPub.Net.ActivityTypes
{
    public class Activity : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;
        private FluentCreateActivity _fluentCreateActivity;
        private CreateActivity _createActivity;

        public Activity(ActivityStream parent) : base(parent)
        {
            _parent = parent;
        }

        public FluentCreateActivity CreateActivity()
        {

            if (_createActivity == null)
            {
                _createActivity = new CreateActivity();
            }
            return _createActivity.InitFluent(_parent, _createActivity);

        }

        public dynamic GetObject()
        {
            return _createActivity;
        }

        internal override string GetJsonBuild()
        {
            var resultString = "";
            if (_createActivity != null) resultString = _createActivity.GetJsonBuild();
            return resultString;
        }

    }

    public class CreateActivity
    {
        private FluentCreateActivity _fluentCreateActivity;
        private ActivityStream _parent;

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
        public dynamic Object { get; set; }

        public string GetJsonBuild()
        {
            if (_fluentCreateActivity != null) return _fluentCreateActivity.GetJsonBuild();
            return "{}";
        }

        public dynamic GetObject()
        {
            if (_fluentCreateActivity != null) return _fluentCreateActivity.GetObject();
            return new ExpandoObject();
        }

        internal FluentCreateActivity InitFluent(ActivityStream parent, CreateActivity createActivity)
        {
            _parent = parent;
            _fluentCreateActivity = new FluentCreateActivity(parent, this);
            return _fluentCreateActivity;

        }
    }
}