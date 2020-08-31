using System;
using System.Collections.Generic;
using System.Text;
using ActivityPub.Net.Enums;

namespace ActivityPub.Net
{
    public class Like : ActivityStreamsBuilder
    {
        public Like Id(string id)
        {
            return this;
        }
    }


    public class Article : ActivityStreamsBuilder
    {

        public Article Id(string id)
        {
            return this;
        }


    }

}
