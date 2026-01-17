using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Museek.Domain;

namespace Museek.Configurations.Entities
{
    public class SongSeed : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            throw new NotImplementedException();
        }
    }
}
