using ActivityPub.Net.CoreTypes;
using ActivityPub.Net.Enums;
using ActivityPub.Net.ObjectAndLinkTypes;

namespace ActivityPub.Net.ActorTypes
{
    public class Actor : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;

        public Actor(ActivityStream parent) : base(parent)
        {
            _parent = parent;
        }
        public Person Person()
        {
            return new Person(_parent);
        }

        public Note Note()
        {
            return new Note(_parent);
        }

        public Group Group()
        {
            return new Group(_parent);
        }


    }
}