using HelpMeApi.Moderation.Enum;

namespace HelpMeApi.Moderation.Model.Request;

public class ModerationActionRequestModel
{
    public ModerationAction Action { get; set; }
    public string ObjectId { get; set; } = null!;
}