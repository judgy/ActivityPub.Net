using System;
using System.Collections.Generic;
using System.Text;
using ActivityPub.Net.ActorTypes;
using ActivityPub.Net.CoreTypes;

namespace ActivityPub.Net
{
    public class ActivityBuilderDirector : ActivityStream
    {
        public static ActivityBuilderDirector NewActivity => new ActivityBuilderDirector();
    }

    public class ActivityBuilder : ActivityStream
    {
        
    }

    //public class PersonBuilder : FluentPerson
    //{
    //    public static PersonBuilder FluentPerson => new PersonBuilder();

    //    public PersonBuilder(ActivityStream parent) : base(parent)
    //    {
    //    }
    //}
}
