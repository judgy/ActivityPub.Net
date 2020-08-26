using System;
using ActivityPub.Net.CoreTypes;
using Newtonsoft.Json;

namespace ActivityPub.Net.ObjectAndLinkTypes
{
    public class ObjectElement : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;
        private FluentNote _fluentNote;
        private FluentArticle _fluentArticle;
        private FluentDocument _fluentDocument;

        public ObjectElement(ActivityStream parent) : base(parent)
        {
            _parent = parent;
        }

        public FluentNote Note()
        {
            return _fluentNote ?? (_fluentNote = new FluentNote(_parent));
        }

        public FluentArticle Article()
        {
            return _fluentArticle ?? (_fluentArticle = new FluentArticle(_parent));
        }

        public FluentDocument Document()
        {
            if (_fluentDocument==null) _fluentDocument = new FluentDocument(_parent);
            return _fluentDocument;
        }

        internal override string GetBuild()
        {
            if (_fluentNote!=null) return _fluentNote.GetBuild();
            if (_fluentArticle != null) return _fluentArticle.GetBuild();
            if (_fluentDocument != null) return _fluentDocument.GetBuild();
            return String.Empty;
        }


    }
}