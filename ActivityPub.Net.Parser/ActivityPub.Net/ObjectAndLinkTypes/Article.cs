using System.Linq;
using ActivityPub.Net.CoreTypes;
using ActivityPub.Net.Enums;

namespace ActivityPub.Net.ObjectAndLinkTypes
{
    public class FluentDocument : ActivityStreamsObject
    {
        private readonly Document _document;

        public FluentDocument(ActivityStream activityStream, Document document) : base(activityStream)
        {
            _document = document;
        }
    }

    public class FluentArticle : ActivityStreamsObject
    {
        private readonly Article _document;

        public FluentArticle(ActivityStream activityStream, Article document) : base(activityStream)
        {
            _document = document;
        }
    }

    public class Article 
    {
        private FluentArticle _fluentArticle;
        public Article(ActivityStream activityStream) 
        {
            _fluentArticle = new FluentArticle(activityStream, this);
        }

        internal FluentArticle FluentArticle()
        {
            return _fluentArticle;
        }

        public string GetJsonBuild()
        {
            if (_fluentArticle != null) return _fluentArticle.GetJsonBuild();
            return "{}";
        }

    }
    public class Audio
    {
        public Audio(ActivityStream activityStream)
        {

        }
    }
    public class Document 
    {
        private FluentDocument _fluentDocument;
        public Document(ActivityStream activityStream)
        {
            _fluentDocument= new FluentDocument(activityStream, this);
        }
        internal FluentDocument FluentDocument()
        {
            return _fluentDocument;
        }

        public string GetJsonBuild()
        {
            if (_fluentDocument != null) return _fluentDocument.GetJsonBuild();
            return "{}";
        }
    }
    public class Event
    {
        public Event(ActivityStream activityStream) 
        {

        }
    }
    public class Image 
    {
        public Image(ActivityStream activityStream)
        {

        }
    }

    public class Page 
    {
        public Page(ActivityStream activityStream) 
        {

        }
    }
    public class Place 
    {
        public Place(ActivityStream activityStream) 
        {

        }
    }
    public class Profile 
    {
        public Profile(ActivityStream activityStream) 
        {

        }
    }
    public class Releationship 
    {
        public Releationship(ActivityStream activityStream) 
        {

        }
    }
    public class Tombstone 
    {
        public Tombstone(ActivityStream activityStream) 
        {

        }
    }
    public class Video
    {
        public Video(ActivityStream activityStream) 
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