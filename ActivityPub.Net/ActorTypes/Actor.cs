using System.Dynamic;
using ActivityPub.Net.CoreTypes;

namespace ActivityPub.Net.ActorTypes
{
    public class Actor : ActivityStreamsObject
    {
        
        private Person _person;

        public Actor(ActivityStream parent) : base(parent)
        {
        }
        public FluentPerson Person()
        {
            
            if (_person == null)
            {
                _person = new Person(ActivityStream);
            }
            return _person.FluentPerson();
        }

        internal override string GetJsonBuild()
        {
            var resultString = "";
            if (_person != null) resultString = _person.GetBuild();
            return resultString;
        }

        public override dynamic GetObject()
        {
            if (_person != null) return _person.GetObject();
            return new ExpandoObject();
        }


    }
}