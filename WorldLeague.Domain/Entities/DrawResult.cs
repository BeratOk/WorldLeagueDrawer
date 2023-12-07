namespace WorldLeague.Domain.Entities
{
    public class DrawResult
    {
        public int Id { get; set; }
        public string DrawerName { get; set; } = null!;
        public string DrawerSurname { get; set; } = null!;
        public List<DrawGroup> Groups { get; set; } = null!;
    }
}
