namespace Museek.Domain
{
    public class Song:BaseDomainModel
    {
        public string? Title {get; set; }
        public string? Audio_File { get; set; }
        public int Duration { get; set; }
        public string? Cover_Art { get; set; }
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }
    }
}
