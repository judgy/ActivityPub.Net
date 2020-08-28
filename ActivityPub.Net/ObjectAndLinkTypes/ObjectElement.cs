using System;
using System.Dynamic;
using ActivityPub.Net.CoreTypes;
using Newtonsoft.Json;

namespace ActivityPub.Net.ObjectAndLinkTypes
{
    public class ObjectElement : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;
        private FluentNote _fluentNote;
        private Note _note;
        private FluentArticle _fluentArticle;
        private FluentDocument _fluentDocument;

        public ObjectElement(ActivityStream parent) : base(parent)
        {
            _parent = parent;
        }

        public FluentNote Note()
        {
            if (_note == null)
            {
                _note = new Note();
            }
            return _note.InitFluent(_parent);
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

        public dynamic GetObject()
        {
            if (_note != null) return _note.GetObject();
            //if (_fluentArticle != null) return _fluentArticle.GetObject();
            //if (_fluentDocument != null) return _fluentDocument.GetObject();
            return new ExpandoObject();
        }

        internal override string GetJsonBuild()
        {
            if (_note != null) return _note.GetJsonBuild();
            if (_fluentArticle != null) return _fluentArticle.GetJsonBuild();
            if (_fluentDocument != null) return _fluentDocument.GetJsonBuild();
            return String.Empty;
        }


    }
}