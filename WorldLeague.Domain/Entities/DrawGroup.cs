namespace WorldLeague.Domain.Entities
{
    public class DrawGroup
    {
        public int Id {get; set; }
        public string Name { get; set; } = null!;
        public List<Team> Teams { get; set; } = null!;
    }
}
