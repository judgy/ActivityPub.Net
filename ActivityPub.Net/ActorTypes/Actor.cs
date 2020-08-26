using ActivityPub.Net.CoreTypes;
using ActivityPub.Net.Enums;
using ActivityPub.Net.ObjectAndLinkTypes;

namespace ActivityPub.Net.ActorTypes
{
    public class Actor : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;
        private FluentPerson _fluentPerson;

        public Actor(ActivityStream parent) : base(parent)
        {
            _parent = parent;
        }
        public FluentPerson Person()
        {
            return _fluentPerson ?? (_fluentPerson = new FluentPerson(_parent));
        }


        internal override string GetBuild()
        {
            var resultString = "";
            if (_fluentPerson!=null) resultString = _fluentPerson.GetBuild();
            return resultString;
        }

    }
}