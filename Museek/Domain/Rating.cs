namespace Museek.Domain
{
    public class Rating : BaseDomainModel
    {
        public string? Comment { get; set; }
        public string UserId { get; set; } = default!;
        public int SongId { get; set; }
    }
}
