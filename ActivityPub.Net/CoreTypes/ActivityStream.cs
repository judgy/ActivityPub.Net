using System.Runtime.CompilerServices;
using ActivityPub.Net.ActorTypes;

namespace ActivityPub.Net.CoreTypes
{
    public class ActivityStream : ActivityStreamsObject
    {
        private Actor _actor;

        public ActivityStream() 
        {
            _actor = new Actor(this);
        }

        public Actor Actor()
        {
            return _actor;
        }

        public override ActivityStream End()
        {
            return this;
        }

        //public AdvancedActorActivity ActorObject()
        //{
        //    return new AdvancedActorActivity(this);
        //}
    }
}
