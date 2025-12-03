namespace Museek.Domain
{
    public class Rating : BaseDomainModel
    {
        public string? Comment { get; set; }
        public int UserId { get; set; }
        public int SongId { get; set; }
    }
}
