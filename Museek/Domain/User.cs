namespace Museek.Domain
{
    public class User : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Profile_Picture { get; set; }
    }
}
