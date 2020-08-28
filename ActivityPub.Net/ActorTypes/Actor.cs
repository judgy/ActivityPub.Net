using System.Dynamic;
using ActivityPub.Net.CoreTypes;
using ActivityPub.Net.Enums;
using ActivityPub.Net.ObjectAndLinkTypes;

namespace ActivityPub.Net.ActorTypes
{
    public class Actor : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;
        private Person _person;

        public Actor(ActivityStream parent) : base(parent)
        {
            _parent = parent;
        }
        public FluentPerson Person()
        {
            
            if (_person == null)
            {
                _person = new Person();
            }
            return _person.InitFluent(_parent);
        }

        internal override string GetJsonBuild()
        {
            var resultString = "";
            if (_person != null) resultString = _person.GetBuild();
            return resultString;
        }

        public dynamic GetObject()
        {
            if (_person != null) return _person.GetObject();
            return new ExpandoObject();
        }


    }
}