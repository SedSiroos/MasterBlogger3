using System;
using MB.Application.ArticleCategoryApplication;
using MB.Application.Contracts.IArticleCategory;
using MB.Domain.IRepository;
using MB.Infrastructure.EFCore.DbContext;
using MB.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace MB.Infrastructor
{
    public class BootStraper
    {
        public static void Config(IServiceCollection service, string connectionString)
        {
            service.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            service.AddTransient<IArticleCategoryApllication,ArticleCategoryApplication>();
            service.AddDbContextPool<MasterBloggerContext>(opt =>
                opt.UseSqlServer(connectionString));
        }
    }
}
