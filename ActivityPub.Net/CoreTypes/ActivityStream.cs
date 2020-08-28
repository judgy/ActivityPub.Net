using System.Dynamic;
using System.Runtime.CompilerServices;
using ActivityPub.Net.ActivityTypes;
using ActivityPub.Net.ActorTypes;
using ActivityPub.Net.ObjectAndLinkTypes;

namespace ActivityPub.Net.CoreTypes
{
    public class ActivityStream : ActivityStreamsObject
    {
        private Actor _actor;
        private ObjectElement _objectElement;
        private Activity _activity;

        public Actor Actor()
        {
            if (_actor == null) _actor = new Actor(this);
            return _actor;
        }

        public ObjectElement ObjectElement()
        {
            if (_objectElement == null) _objectElement = new ObjectElement(this);
            return _objectElement;
        }

        public Activity Activity()
        {
            if (_activity == null) _activity = new Activity(this);
            return _activity;
        }

        public string Build()
        {
            var buildString = string.Empty;
            if (_actor != null)
            {
                buildString = _actor.GetJsonBuild();
            }
            else if (_objectElement != null)
            {
                buildString = _objectElement.GetJsonBuild();
            }
            else if (_activity != null)
            {
                buildString = _activity.GetJsonBuild();
            }
            return buildString;
        }

        //public AdvancedActorActivity ActorObject()
        //{
        //    return new AdvancedActorActivity(this);
        //}
        public dynamic GetObject()
        {
            if (_actor != null)
            {
                return _actor.GetObject();
            }
            else if (_objectElement != null)
            {
                return _objectElement.GetObject();
            }
            else if (_activity != null)
            {
                return _activity.GetObject();
            }

            return new ExpandoObject();
        }
    }

    //public class ActorStream : ActivityStreamsBuilder
    //{
    //    private Actor _actor;

    //    public ActorStream()
    //    {
    //        _actor = new Actor(this);
    //    }

    //    public Actor Actor()
    //    {
    //        return _actor;
    //    }

    //    public override ActorStream End()
    //    {
    //        return this;
    //    }

    //    public string Build()
    //    {
    //        ActictityStreamBuiler.Insert(0, "{");
    //        ActictityStreamBuiler.Append("}");
    //        return ActictityStreamBuiler.ToString();

    //    }

    //    //public AdvancedActorActivity ActorObject()
    //    //{
    //    //    return new AdvancedActorActivity(this);
    //    //}
    //}

}
