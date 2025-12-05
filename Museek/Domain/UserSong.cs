namespace Museek.Domain
{
    public class UserSong: BaseDomainModel
    {
        public string UserId { get; set; } = default!;

        public int SongId { get; set; }
    }
}
