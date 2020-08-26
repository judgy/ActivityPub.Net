using System.Runtime.CompilerServices;
using ActivityPub.Net.ActorTypes;
using ActivityPub.Net.ObjectAndLinkTypes;

namespace ActivityPub.Net.CoreTypes
{
    public class ActivityStream : ActivityStreamsObject
    {
        private Actor _actor;
        private ObjectElement _objectElement;

        public ActivityStream() 
        {
            
            _objectElement = new ObjectElement(this);
        }

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

        public string Build()
        {
            var buildString = string.Empty;
            if (_actor != null)
            {
                buildString = _actor.GetBuild();
            }
            else if (_objectElement != null)
            {
                buildString = _objectElement.GetBuild();
            }
            return buildString;
        }

        //public AdvancedActorActivity ActorObject()
        //{
        //    return new AdvancedActorActivity(this);
        //}
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
