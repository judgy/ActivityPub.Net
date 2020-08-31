using System.Linq;
using ActivityPub.Net.CoreTypes;
using Newtonsoft.Json.Linq;

namespace ActivityPub.Net.ObjectAndLinkTypes
{
    public class FluentNote : ActivityStreamsObject
    {
        private readonly Note _note;

        public FluentNote(ActivityStream activityStream, Note note) : base(activityStream)
        {
            _note = note;
            JsonObject.Add("@context", "https://www.w3.org/ns/activitystreams");
            _note.Context = "https://www.w3.org/ns/activitystreams";
            JsonObject.Add("type", "Note");
            _note.Type = "Note";
        }

        public FluentNote Id(string id)
        {
            if (JsonObject.ContainsKey("id")) JsonObject.Remove("id");
            JsonObject.Add("id", id);
            _note.Id = id;
            return this;
        }

        public FluentNote To(string to)
        {
            if (_note.To.FirstOrDefault(p => p == to) == null) _note.To.Add(to);
            return this;
        }

        public FluentNote AttributedTo(string attributedTo)
        {
            if (JsonObject.ContainsKey("attributedTo")) JsonObject.Remove("attributedTo");
            JsonObject.Add("attributedTo", attributedTo);

            _note.AttributedTo = attributedTo;
            return this;
        }

        public FluentNote Content(string content)
        {
            if (JsonObject.ContainsKey("content")) JsonObject.Remove("content");
            JsonObject.Add("content", content);

            _note.Content = content;
            return this;
        }

        public FluentNote InReplyTo(string inReplyTo)
        {
            if (JsonObject.ContainsKey("inReplyTo")) JsonObject.Remove("inReplyTo");
            JsonObject.Add("inReplyTo", inReplyTo);

            _note.InReplyTo = inReplyTo;
            return this;
        }

        public ActivityStream EndNote()
        {
            return ActivityStream;
        }

        internal override string GetJsonBuild()
        {
            PrepareJsonObject();
            return base.GetJsonBuild();
        }

        public override dynamic GetObject()
        {
            PrepareJsonObject();
            return base.GetObject();
        }

        private void PrepareJsonObject()
        {
            if (_note.To.Any())
            {
                if (JsonObject.ContainsKey("to")) JsonObject.Remove("to");
                var toArray = new JArray();
                foreach (var toItem in _note.To) toArray.Add(toItem);
                JsonObject.Add("to", toArray);
            }
        }


        //internal string BuildObject(Note note)
        //{
        //    return JsonConvert.SerializeObject(note);
        //}
    }
}