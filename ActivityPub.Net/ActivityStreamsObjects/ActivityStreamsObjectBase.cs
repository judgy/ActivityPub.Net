namespace ActivityPub.Net.ActivityStreamsObjects
{
    public class ActivityStreamsObjectBase : ActivityStreamsBuilder
    {
        public Attachment Attachment(string attachment)
        {
            return new Attachment(this);
        }

        //public AdvancedActorActivity AttributedTo(string attributedTo)
        //{
        //    return new AdvancedActorActivity(this);
        //}

    }

    public class Attachment : ActivityStreamsBuilder
    {
        private readonly ActivityStreamsBuilder _baseObject;

        public Attachment(ActivityStreamsBuilder baseObject)
        {
            _baseObject = baseObject;
        }
        public Attachment AttributedTo(string attributedTo)
        {
            return this;
        }

        public ActivityStreamsBuilder End()
        {
            return _baseObject;
        }


    }

}