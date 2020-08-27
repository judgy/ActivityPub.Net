using ActivityPub.Net.CoreTypes;
using ActivityPub.Net.ObjectAndLinkTypes;
using Newtonsoft.Json;

namespace ActivityPub.Net.ActivityTypes
{
    public class FluentCreateActivity : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;
        CreateActivity _createActivity;

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
            _createActivity.Object = objectActivity;
            return this;
        }

        protected CreateActivity GetCreateActivity()
        {
            return _createActivity;
        }

        public ActivityStream EndCreateActivity()
        {
            return _parent;
        }

        internal override string GetBuild()
        {
            return JsonConvert.SerializeObject(_createActivity);
        }



    }
}