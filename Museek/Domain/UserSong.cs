namespace Museek.Domain
{
    public class UserSong: BaseDomainModel
    {
        public int UserId { get; set; }
        public int SongId { get; set; }
    }
}
