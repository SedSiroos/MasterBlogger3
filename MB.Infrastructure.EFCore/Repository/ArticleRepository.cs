using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using MB.Application.Contracts.ArticleViewModel;
using MB.Domain.IRepository;
using MB.Infrastructure.EFCore.DbContext;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.EFCore.Repository
{
    public class ArticleRepository:IArticleRepository
    {
        private readonly MasterBloggerContext _context;

        public ArticleRepository(MasterBloggerContext context)
        {
            _context = context;
        }

        public List<ArticleViewModel> GetList()
        {
            return _context.Articles.Include(x => x.ArticleCategory)
                .Select(x => new ArticleViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    IsDeleted = false,
                    ArticleCategory = x.ArticleCategory.Title,
                    CreationDate = x.CreationDate
                }).ToList();
        }
    }
}
