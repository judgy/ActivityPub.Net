using System;
using System.Dynamic;
using ActivityPub.Net.CoreTypes;


namespace ActivityPub.Net.ObjectAndLinkTypes
{
    public class ObjectElement : ActivityStreamsObject
    {
        private Note _note;
        private Article _article;
        private Document _document;

        public ObjectElement(ActivityStream parent) : base(parent)
        {
        }

        public FluentNote Note()
        {
            if (_note == null) _note = new Note(ActivityStream);
            return _note.FluentNote();
        }

        public FluentArticle Article()
        {
            if (_article == null) _article = new Article(ActivityStream);

            return _article.FluentArticle();
        }

        public FluentDocument Document()
        {
            if (_document == null) _document = new Document(ActivityStream);
            return _document.FluentDocument();
        }

        public override dynamic GetObject()
        {
            if (_note != null) return _note.GetObject();
            //if (_fluentArticle != null) return _fluentArticle.GetObject();
            //if (_fluentDocument != null) return _fluentDocument.GetObject();
            return new ExpandoObject();
        }

        internal override string GetJsonBuild()
        {
            if (_note != null) return _note.GetJsonBuild();
            if (_article != null) return _article.GetJsonBuild();
            if (_document != null) return _document.GetJsonBuild();
            return String.Empty;
        }


    }
}