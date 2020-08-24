using ActivityPub.Net.Enums;

namespace ActivityPub.Net
{
    public class ActivityPubBuilder<T> : ActivityStreamsBuilder where T : ActivityPubBuilder<T>
    {

        public T Id(string id)
        {
            //employee.Name = name;
            return (T)this;
        }

        public T Type(ActivityStreamType type)
        {
            //employee.Name = name;
            return (T)this;
        }

        public T CustomType(string customTypeText)
        {
            //employee.Name = name;
            return (T)this;
        }

    }
}