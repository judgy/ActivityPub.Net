using ActivityPub.Net.CoreTypes;

namespace ActivityPub.Net.ActorTypes
{
    public class Group : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;

        public Group(ActivityStream parent) : base(parent)
        {
            _parent = parent;
        }

        public virtual ActivityStream End()
        {
            return _parent;
        }

    }
}