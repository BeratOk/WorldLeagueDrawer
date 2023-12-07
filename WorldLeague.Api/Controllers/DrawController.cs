using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorldLeague.Application.Draw.CreateDraw;
using WorldLeague.Domain.Entities;

namespace WorldLeague.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DrawController : ControllerBase
{
    private readonly IMediator _mediator;
    public DrawController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<DrawResult> PostAsync(CreateDrawRequest payload)
    {
        var drawResult = await _mediator.Send(payload);
        return drawResult;
    }
}