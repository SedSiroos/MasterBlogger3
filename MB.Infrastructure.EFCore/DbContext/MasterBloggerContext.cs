using System;
using System.Collections.Generic;
using System.Text;
using MB.Domain.Article;
using MB.Domain.ArticleCategory;
using MB.Infrastructure.EFCore.Mappings;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.EFCore.DbContext
{
    public class MasterBloggerContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<Article> Articles { get; set; }

        public MasterBloggerContext(DbContextOptions<MasterBloggerContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleCategorymapping());
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
