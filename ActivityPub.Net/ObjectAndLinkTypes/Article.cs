using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActivityPub.Net.CoreTypes;
using ActivityPub.Net.Enums;

namespace ActivityPub.Net.ObjectAndLinkTypes
{
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
    public class Note : ActivityStreamsObject
    {
        private readonly ActivityStream _activityStream;
        private readonly StringBuilder _localActivityBuilder;
        protected List<string> _toList;

        public Note(ActivityStream activityStream) : base(activityStream)
        {
            _activityStream = activityStream;
            _localActivityBuilder = new StringBuilder();
            _toList= new List<string>();
            
            _localActivityBuilder.Append("\"type\": \"Note\"");
        }

        public Note To(string to)
        {
            _toList.Add(to);
            return this;
        }

        public Note AttributedTo(string attributedTo)
        {
            _localActivityBuilder.AppendLine(",");
            _localActivityBuilder.Append($"\"attributedTo\": \"{attributedTo}\"");
            return this;
        }

        public Note Content(string content)
        {
            _localActivityBuilder.AppendLine(",");
            _localActivityBuilder.Append($"\"content\": \"{content}\"");
            return this;
        }

        public new Note End()
        {
            if (_toList.Count > 0)
            {
                var toListJoin = string.Join("\",\"", _toList);
                _localActivityBuilder.AppendLine(",");
                _localActivityBuilder.Append($"\"to\": [\"{toListJoin}\"]");
            }
            ActictityStreamBuiler.Append(_localActivityBuilder);
            return this;
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
    public class Mention : Link
    {
        public Mention(ActivityStream activityStream) : base(activityStream)
        {

        }
    }
}