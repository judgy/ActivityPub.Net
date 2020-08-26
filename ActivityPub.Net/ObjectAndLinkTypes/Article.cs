using System.Linq;
using ActivityPub.Net.CoreTypes;
using ActivityPub.Net.Enums;

namespace ActivityPub.Net.ObjectAndLinkTypes
{
    public class FluentDocument : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;

        public FluentDocument(ActivityStream parent)
        {
            _parent = parent;
        }
    }

    public class FluentArticle : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;

        public FluentArticle(ActivityStream parent)
        {
            _parent = parent;
        }
    }

    public class Article : ActivityStreamsObject
    {
        public Article(ActivityStream activityStream) : base(activityStream)
        {
            
        }
    }
    public class Audio: ActivityStreamsObject
    {
        public Audio(ActivityStream activityStream) : base(activityStream)
        {

        }
    }
    public class Document : ActivityStreamsObject
    {
        public Document(ActivityStream activityStream) : base(activityStream)
        {

        }
    }
    public class Event : ActivityStreamsObject
    {
        public Event(ActivityStream activityStream) : base(activityStream)
        {

        }
    }
    public class Image : ActivityStreamsObject
    {
        public Image(ActivityStream activityStream) : base(activityStream)
        {

        }
    }

    public class Page : ActivityStreamsObject
    {
        public Page(ActivityStream activityStream) : base(activityStream)
        {

        }
    }
    public class Place : ActivityStreamsObject
    {
        public Place(ActivityStream activityStream) : base(activityStream)
        {

        }
    }
    public class Profile : ActivityStreamsObject
    {
        public Profile(ActivityStream activityStream) : base(activityStream)
        {

        }
    }
    public class Releationship : ActivityStreamsObject
    {
        public Releationship(ActivityStream activityStream) : base(activityStream)
        {

        }
    }
    public class Tombstone : ActivityStreamsObject
    {
        public Tombstone(ActivityStream activityStream) : base(activityStream)
        {

        }
    }
    public class Video : ActivityStreamsObject
    {
        public Video(ActivityStream activityStream) : base(activityStream)
        {

        }
    }
    //public class Mention : Link
    //{
    //    public Mention(ActivityStream activityStream) : base(activityStream)
    //    {

    //    }
    //}
}