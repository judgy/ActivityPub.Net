using System.Text;
using ActivityPub.Net.CoreTypes;

namespace ActivityPub.Net.ActorTypes
{
    public class Person : ActivityStreamsObject
    {
        private readonly ActivityStream _parent;
        private readonly StringBuilder _localActivityBuilder;

        public Person(ActivityStream parent) : base(parent)
        {
            _parent = parent;
            _localActivityBuilder = new StringBuilder();
            _localActivityBuilder.Append("\"type\": \"Person\"");
        }

        public new Person Id(string id)
        {
            _localActivityBuilder.AppendLine(",");
            _localActivityBuilder.Append($"\"id\": \"{id}\"");
            return this;
        }

        //public Person Type(ActorType type)
        //{
        //    return this;
        //}

        public Person Following(string following)
        {
            _localActivityBuilder.AppendLine(",");
            _localActivityBuilder.Append($"\"following\": \"{following}\"");
            return this;
        }

        public Person Followers(string followers)
        {
            _localActivityBuilder.AppendLine(",");
            _localActivityBuilder.Append($"\"followers\": \"{followers}\"");
            return this;
        }

        public Person Inbox(string inbox)
        {
            _localActivityBuilder.AppendLine(",");
            _localActivityBuilder.Append($"\"inbox\": \"{inbox}\"");
            return this;
        }

        public Person OutBox(string outbox)
        {
            _localActivityBuilder.AppendLine(",");
            _localActivityBuilder.Append($"\"outbox\": \"{outbox}\"");
            return this;
        }

        public Person PreferredUsername(string preferredUsername)
        {
            _localActivityBuilder.AppendLine(",");
            _localActivityBuilder.Append($"\"preferredUsername\": \"{preferredUsername}\"");
            return this;
        }

        public new Person Name(string name)
        {
            _localActivityBuilder.AppendLine(",");
            _localActivityBuilder.Append($"\"name\": \"{name}\"");
            return this;
        }

        public new Person Summary(string summary)
        {
            _localActivityBuilder.AppendLine(",");
            _localActivityBuilder.Append($"\"summary\": \"{summary}\"");
            return this;
        }

        public Person Liked(string liked)
        {
            _localActivityBuilder.AppendLine(",");
            _localActivityBuilder.Append($"\"liked\": \"{liked}\"");
            return this;
        }

        public new Person End()
        {
            ActictityStreamBuiler.Append(_localActivityBuilder);
            return this;
        }


        //Icon

    }
}