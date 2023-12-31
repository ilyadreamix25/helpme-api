using HelpMeApi.Common.Enum;
using HelpMeApi.Common.Object;
using HelpMeApi.Moderation.Enum;
using HelpMeApi.User.Model;

namespace HelpMeApi.Moderation.Model;

public class ModerationModel
{
    public ModerationAction Action { get; set; }
    public ObjectType ObjectType { get; set; }
    public Guid ActionId { get; set; }
    public Guid ObjectId { get; set; }
    public UserPublicModel Moderator { get; set; } = null!;
    public List<Extra> Extras { get; set; } = null!;
    public long CreatedAt { get; set; }
}
