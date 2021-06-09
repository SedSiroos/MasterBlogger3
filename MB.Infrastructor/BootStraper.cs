using System;
using MB.Application.ArticleApplication;
using MB.Application.ArticleCategoryApplication;
using MB.Application.Contracts.IArticleApplication;
using MB.Application.Contracts.IArticleCategory;
using MB.Domain.IRepository;
using MB.Domain.Services;
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
            service.AddTransient<IArticleCategoryValidationServices, ArticleCategoryValidationService>();
            service.AddTransient<IArticleRepository, ArticleRepository>();
            service.AddTransient<IArticleApplication, ArticleApplication>();
            service.AddDbContextPool<MasterBloggerContext>(opt =>
                opt.UseSqlServer(connectionString));
        }
    }
}
