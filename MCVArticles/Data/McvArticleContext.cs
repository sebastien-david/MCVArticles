using Microsoft.EntityFrameworkCore;
using MCVArticles.Models;

namespace MCVArticles.Data
{
    public class McvArticleContext : DbContext
    {
        public McvArticleContext(DbContextOptions<McvArticleContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Article { get; set; }
    }
}
