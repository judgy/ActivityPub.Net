using System.Linq;
using ActivityPub.Net.CoreTypes;
using ActivityPub.Net.ObjectAndLinkTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ActivityPub.Net.ActivityTypes
{
    public class FluentCreateActivity : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;
        CreateActivity _createActivity;

        private readonly JObject _jsonObject = new JObject();

        public FluentCreateActivity(ActivityStream parent, CreateActivity createActivity) : base(parent)
        {
            _parent = parent;
            _createActivity = createActivity;

            _jsonObject.Add("@context", "https://www.w3.org/ns/activitystreams");
            _createActivity.Context = "https://www.w3.org/ns/activitystreams";
            _jsonObject.Add("type", "Create");
            _createActivity.Type = "Create";

        }
        public new FluentCreateActivity Id(string id)
        {
            if (_jsonObject.ContainsKey("id")) _jsonObject.Remove("id");
            _jsonObject.Add("id", id);
            _createActivity.Id = id;

            return this;
        }

        public FluentCreateActivity To(string to)
        {
            if (_createActivity.To.FirstOrDefault(p => p == to) == null) _createActivity.To.Add(to);
            return this;
        }

        public FluentCreateActivity Actor(string actor)
        {
            if (_jsonObject.ContainsKey("actor")) _jsonObject.Remove("actor");
            _jsonObject.Add("actor", actor);

            _createActivity.Actor = actor;
            return this;
        }

        public FluentCreateActivity ActivityObject(JObject objectActivity)
        {
            var localobjectActivity = objectActivity;
            if (localobjectActivity != null && localobjectActivity.ContainsKey("@context")) localobjectActivity.Remove("@context");
            _createActivity.Object = localobjectActivity;
            return this;
        }

        //public FluentCreateActivity ActivityObject3(string objectActivity)
        //{
        //    return this;
        //}

        //public FluentCreateActivity ActivityObject()
        //{
        //    return this;
        //}

        protected CreateActivity GetCreateActivity()
        {
            return _createActivity;
        }

        public ActivityStream EndCreateActivity()
        {
            return _parent;
        }

        internal override string GetJsonBuild()
        {
            CreateObject();
            return JsonConvert.SerializeObject(_createActivity);
        }

        public dynamic GetObject()
        {
            CreateObject();
            return _jsonObject;
        }

        private void CreateObject()
        {
            if (_createActivity.To.Any())
            {
                if (_jsonObject.ContainsKey("to")) _jsonObject.Remove("to");
                var toArray = new JArray();
                foreach (var toItem in _createActivity.To) toArray.Add(toItem);
                _jsonObject.Add("to", toArray);
            }
        }


    }
}