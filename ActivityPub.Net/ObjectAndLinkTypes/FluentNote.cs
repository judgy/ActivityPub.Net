using System.Linq;
using ActivityPub.Net.CoreTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ActivityPub.Net.ObjectAndLinkTypes
{
    public class FluentNote : ActivityStreamsObject
    {
        private readonly ActivityStream _activityStream;
        private readonly Note _note;

        private readonly JObject _noteObject = new JObject();

        public FluentNote(ActivityStream activityStream, Note note) : base(activityStream)
        {
            _activityStream = activityStream;
            _note = note;
            _noteObject.Add("@context", "https://www.w3.org/ns/activitystreams");
            _note.Context = "https://www.w3.org/ns/activitystreams";
            _noteObject.Add("type", "Note");
            _note.Type = "Note";
        }

        public new FluentNote Id(string id)
        {
            if (_noteObject.ContainsKey("id")) _noteObject.Remove("id");
            _noteObject.Add("id", id);
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
            if (_noteObject.ContainsKey("attributedTo")) _noteObject.Remove("attributedTo");
            _noteObject.Add("attributedTo", attributedTo);

            _note.AttributedTo = attributedTo;
            return this;
        }

        public FluentNote Content(string content)
        {
            if (_noteObject.ContainsKey("content")) _noteObject.Remove("content");
            _noteObject.Add("content", content);

            _note.Content = content;
            return this;
        }

        public ActivityStream EndNote()
        {
            return _activityStream;
        }

        public Note GetNote()
        {
            return _note;
        }

        internal override string GetJsonBuild()
        {
            CreateObject();
            return JsonConvert.SerializeObject(_noteObject);
        }

        public dynamic GetObject()
        {
            CreateObject();
            return _noteObject;
        }

        private void CreateObject()
        {
            if (_note.To.Any())
            {
                if (_noteObject.ContainsKey("to")) _noteObject.Remove("to");
                var toArray = new JArray();
                foreach (var toItem in _note.To) toArray.Add(toItem);
                _noteObject.Add("to", toArray);
            }
        }


        internal string BuildObject(Note note)
        {
            return JsonConvert.SerializeObject(note);
        }
    }
}