namespace Museek.Domain
{
    public class Song:BaseDomainModel
    {
        public string? Title {get; set; }
        public int Duration { get; set; }
        public DateTime Release_Date { get; set; }
        public string? Cover_Art { get; set; }
        public int AlbumId { get; set; }
    }
}
