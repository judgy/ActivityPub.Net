using Newtonsoft.Json;

namespace ActivityPub.Net.ObjectAndLinkTypes
{
    public class SerializableObject
    {
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}