using ActivityPub.Net.CoreTypes;

namespace ActivityPub.Net.ActorTypes
{
    public class Service : ActivityStreamsObject
    {
        protected Service(ActivityStream activityStream) : base(activityStream)
        {
        }
    }
}