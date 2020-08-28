using System;
using System.Text;
using ActivityPub.Net.Enums;

namespace ActivityPub.Net
{
    public abstract class ActivityStreamsBuilder
    {
        protected StringBuilder ActictityStreamBuiler;
        //public ActivityStreamType Type { get; set; }


        protected ActivityStreamsBuilder()
        {
            ActictityStreamBuiler = new StringBuilder();
            ActictityStreamBuiler.AppendLine("\"@context\": \"https://www.w3.org/ns/activitystreams\",");
        }

        internal virtual string GetJsonBuild()
        {
            return string.Empty;
            //    ActictityStreamBuiler.Insert(0, "{");
            //    ActictityStreamBuiler.Append("}");
            //    return ActictityStreamBuiler.ToString();

        }
    }
}
