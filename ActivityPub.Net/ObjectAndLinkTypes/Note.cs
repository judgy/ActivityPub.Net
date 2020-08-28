using System.Collections.Generic;
using System.Dynamic;
using ActivityPub.Net.ActorTypes;
using ActivityPub.Net.CoreTypes;
using Newtonsoft.Json;

namespace ActivityPub.Net.ObjectAndLinkTypes
{
    public class Note
    {
        private ActivityStream _parent;
        private FluentNote _fluentNote;

        internal Note()
        {
            To= new List<string>();
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

        internal FluentNote InitFluent(ActivityStream parent)
        {
            _parent = parent;
            _fluentNote = new FluentNote(parent, this);
            return _fluentNote;
        }

        public dynamic GetObject()
        {
            if (_fluentNote != null) return _fluentNote.GetObject();
            return new ExpandoObject();
        }

        public string GetJsonBuild()
        {
            if (_fluentNote != null) return _fluentNote.GetJsonBuild();
            return "{}";
        }


    }
}
