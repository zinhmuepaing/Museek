namespace Museek.Domain
{
    public class Album : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Released_Year { get; set; }
        public string? Cover_Image { get; set; }
        public int ArtistId { get; set; }
    }
}
