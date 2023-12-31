namespace HelpMeApi.Common.State;

public enum StateCode
{
    Ok,
    InternalServerError,
    InvalidRequest,
    ContentNotFound,
    InvalidMethod,
    ServiceUnavailable,
    UserAlreadyExists,
    UserDoesNotExist,
    Unauthorized,
    InvalidCredentials,
    TooManyRequests,
    TooYoung,
    NicknameUnavailable,
    InvalidIdToken,
    EmailIsNotVerified,
    YouAreBanned,
    NoRights,
    InvalidAction,
    YouCannotPunishYourself,
    YouHaveAlreadyJoinedThisChat,
    YouAreBannedInThisChat,
    ThisChatIsDisabled,
    YouWasNotInvitedToThisChat,
    UserHasAlreadyJoinedThisChat,
    UserWasAlreadyInvited,
    YouCannotEditThisChat,
    UnbanUserToInvite,
    ConnectionDoesNotExist,
    YouHaveNotJoinedThisChat
}
