using HelpMeApi.Common.Auth;
using HelpMeApi.Common.Enum;
using HelpMeApi.Moderation.Enum;
using HelpMeApi.Moderation.Model.Request;
using HelpMeApi.User.Enum;
using Microsoft.AspNetCore.Mvc;

namespace HelpMeApi.Moderation;

[Route("moderation")]
[AuthRequired(Roles = new[] { UserRole.Moderator, UserRole.Support })]
[ApiController]
public class ModerationController : ControllerBase
{
    private readonly ModerationService _moderationService;

    public ModerationController(ModerationService moderationService)
    {
        _moderationService = moderationService;
    }

    [HttpPost("action")]
    public async Task<IActionResult> Action([FromBody] ModerationActionRequestModel body)
    {
        var iState = await _moderationService.Action(body);
        HttpContext.Response.StatusCode = (int)iState.StatusCode;
        return new JsonResult(iState.Model);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var iState = await _moderationService.Get(id);
        HttpContext.Response.StatusCode = (int)iState.StatusCode;
        return new JsonResult(iState.Model);
    }
    
    [HttpGet("list")]
    public async Task<IActionResult> List(
        Guid objectId,
        Guid? moderatorId,
        ModerationAction? action,
        int offset = 0,
        int size = 25,
        OrderingMethod orderingMethod = OrderingMethod.ByTime)
    {
        var state = await _moderationService.List(
            objectId: objectId,
            moderatorId: moderatorId,
            action: action,
            offset: offset,
            size: size,
            orderingMethod: orderingMethod);
        
        return new JsonResult(state);
    }
}
