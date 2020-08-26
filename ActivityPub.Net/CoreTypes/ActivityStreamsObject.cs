using ActivityPub.Net.ActivityStreamsObjects;

namespace ActivityPub.Net.CoreTypes
{
    public class ActivityStreamsObject : ActivityStreamsBuilder
    {
        private readonly ActivityStream _activityStream;

        public ActivityStreamsObject()
        {
            
        }
        protected ActivityStreamsObject(ActivityStream activityStream)
        {
            _activityStream = activityStream;
        }

        public ActivityStreamsObject Id(string id)
        {
            return _activityStream;
        }

        public ActivityStreamsObject Summary(string summary)
        {
            return _activityStream;
        }

        public ActivityStreamsObject Name(string name)
        {
            return _activityStream;
        }

        public Attachment Attachment(string attachment)
        {
            return new Attachment(_activityStream);
        }

        //public virtual ActivityStream End()
        //{
        //    return _activityStream;
        //}

        internal override string GetBuild()
        {
            return base.GetBuild();
        }
    }
}
