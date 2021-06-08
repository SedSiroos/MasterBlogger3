using System;
using System.Collections.Generic;
using System.Text;
using MB.Domain.ArticleCategory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Infrastructure.EFCore.Mappings
{
    public class ArticleCategorymapping : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.ToTable("ArticleCategories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.IsDeleted);
            builder.Property(x => x.CreationDate);
        }
    }
}
