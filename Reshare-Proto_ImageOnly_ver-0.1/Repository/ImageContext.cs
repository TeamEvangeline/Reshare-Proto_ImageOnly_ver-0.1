using Microsoft.EntityFrameworkCore;
using Reshare_Proto_ImageOnly_ver_0._1.Models;

namespace Reshare_Proto_ImageOnly_ver_0._1.Repository
{
    public class ImageContext : DbContext
    {
        public ImageContext(DbContextOptions<ImageContext> options) : base(options)
        { }

        public DbSet<ImageModel> Images { get; set; }
    }
}
