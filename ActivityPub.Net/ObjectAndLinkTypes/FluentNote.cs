using System.Collections.Generic;
using System.Text;
using ActivityPub.Net.CoreTypes;
using Newtonsoft.Json;

namespace ActivityPub.Net.ObjectAndLinkTypes
{
    public class FluentNote : ActivityStreamsObject
    {
        private readonly ActivityStream _activityStream;
        private Note _note;
        public FluentNote(ActivityStream activityStream) : base(activityStream)
        {
            _activityStream = activityStream;
            _note= new Note();
        }

        public new FluentNote Id(string id)
        {
            _note.Id =id;
            return this;
        }

        public FluentNote To(string to)
        {
            _note.To.Add(to);
            return this;
        }

        public FluentNote AttributedTo(string attributedTo)
        {
            _note.AttributedTo=attributedTo;
            return this;
        }

        public FluentNote Content(string content)
        {
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

        internal override string GetBuild()
        {
            return JsonConvert.SerializeObject(_note);
        }

        internal string BuildObject(Note note)
        {
            return JsonConvert.SerializeObject(note);
        }

    }
}