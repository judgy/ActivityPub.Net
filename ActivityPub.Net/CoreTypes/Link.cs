using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPub.Net.CoreTypes
{
    public class Link : ActivityStreamsObject
    {
        private readonly ActivityStream _activityStream;

        protected Link(ActivityStream activityStream):base(activityStream)
        {
            _activityStream = activityStream;
        }
    }
}
