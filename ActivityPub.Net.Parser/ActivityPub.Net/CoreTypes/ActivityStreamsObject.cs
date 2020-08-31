using ActivityPub.Net.ActivityStreamsObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ActivityPub.Net.CoreTypes
{
    public class ActivityStreamsObject : ActivityStreamsBuilder
    {
        private readonly ActivityStream _activityStream;

        internal JObject JsonObject { get; set; }
        internal ActivityStream ActivityStream { get; set; }

        protected ActivityStreamsObject(ActivityStream activityStream)
        {
            JsonObject = new JObject();
            _activityStream = activityStream;
            ActivityStream = activityStream;
        }

        //public ActivityStreamsObject Id(string id)
        //{
        //    return _activityStream;
        //}

        //public ActivityStreamsObject Summary(string summary)
        //{
        //    return _activityStream;
        //}

        //public ActivityStreamsObject Name(string name)
        //{
        //    return _activityStream;
        //}

        //public Attachment Attachment(string attachment)
        //{
        //    return new Attachment(_activityStream);
        //}

        //public virtual ActivityStream End()
        //{
        //    return _activityStream;
        //}

        internal virtual string GetJsonBuild()
        {
            return JsonConvert.SerializeObject(JsonObject);
        }

        public virtual dynamic GetObject()
        {
            return JsonObject;
        }

    }
}
