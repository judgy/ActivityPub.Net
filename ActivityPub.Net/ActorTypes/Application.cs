using ActivityPub.Net.CoreTypes;

namespace ActivityPub.Net.ActorTypes
{
    public class Application : ActivityStreamsObject
    {
        protected Application(ActivityStream activityStream) : base(activityStream)
        {
        }
    }
}