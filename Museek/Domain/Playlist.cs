namespace Museek.Domain
{
    public class Playlist: BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int AdminId { get; set; }
        public int UserId { get; set; }
    }
}
