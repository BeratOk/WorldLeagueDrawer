using AutoMapper;

namespace WorldLeague.Application.Draw.CreateDraw;

public class CreateDraw:Profile
{
    public CreateDraw()
    {
        CreateMap<CreateDrawRequest, Domain.Entities.DrawResult>();
    }
}