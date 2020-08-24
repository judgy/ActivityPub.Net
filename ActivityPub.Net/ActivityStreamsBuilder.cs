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

        public string Build()
        {
            ActictityStreamBuiler.Insert(0, "{");
            ActictityStreamBuiler.Append("}");
            return ActictityStreamBuiler.ToString();
            
        }
    }
}
