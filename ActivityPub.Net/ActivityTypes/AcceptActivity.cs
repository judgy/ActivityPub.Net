using ActivityPub.Net.CoreTypes;

namespace ActivityPub.Net.ActivityTypes
{
    public class AcceptActivity : ActivityStream
    {
    }


    public class TentativeAcceptActivity : AcceptActivity
    {
    }

    public class AddActivity : ActivityStream
    {
    }


    public class ArriveActivity : IntransitiveActivity
    {
        protected ArriveActivity(ActivityStream activityStream) : base(activityStream)
        {
        }
    }

    public class CreateActivity : ActivityStream
    {
    }

    public class DeleteActivity : ActivityStream
    {
    }

    public class FollowActivity : ActivityStream
    {
    }

    public class IgnoreActivity : ActivityStream
    {
    }

    public class JoinActivity : ActivityStream
    {
    }

    public class LeaveActivity : ActivityStream
    {
    }

    public class LikeActivity : ActivityStream
    {
    }

    public class OfferActivity : ActivityStream
    {
    }

    public class InviteActivity : OfferActivity
    {
    }

    public class RejectActivity : ActivityStream
    {
    }

    public class TentativeRejectActivity : RejectActivity
    {
    }

    public class RemoveActivity : ActivityStream
    {
    }

    public class UndoActivity : ActivityStream
    {
    }

    public class UpdateActivity : ActivityStream
    {
    }

    public class ViewActivity : ActivityStream
    {
    }

    public class ListenActivity : ActivityStream
    {
    }

    public class ReadActivity : ActivityStream
    {
    }

    public class MoveActivity : ActivityStream
    {
    }

    public class TravelActivity : IntransitiveActivity
    {
        protected TravelActivity(ActivityStream activityStream) : base(activityStream)
        {
        }
    }

    public class AnnounceActivity : ActivityStream
    {
    }

    public class BlogActivity : ActivityStream
    {
    }

    public class FlagActivity : ActivityStream
    {
    }

    public class DislikeActivity : ActivityStream
    {
    }

    public class QuestionActivity : IntransitiveActivity
    {
        protected QuestionActivity(ActivityStream activityStream) : base(activityStream)
        {
        }
    }
}