using MediatR;
using WorldLeague.Domain.Entities;

namespace WorldLeague.Application.Draw.CreateDraw;
public class CreateDrawRequest : IRequest<DrawResult>
{
    public string DrawerName { get; set; } = null!;
    public string DrawerSurname { get; set; } = null!;
    public int GroupCount{get;set;}
}
