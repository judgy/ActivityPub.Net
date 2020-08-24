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

    //public class PersonBuilder : Person
    //{
    //    public static PersonBuilder Person => new PersonBuilder();

    //    public PersonBuilder(ActivityStream parent) : base(parent)
    //    {
    //    }
    //}
}
