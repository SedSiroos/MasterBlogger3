using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MB.Domain.ArticleCategory;
using MB.Domain.IRepository;
using MB.Infrastructure.EFCore.DbContext;

namespace MB.Infrastructure.EFCore.Repository
{
   public class ArticleCategoryRepository: IArticleCategoryRepository
   {
       private readonly MasterBloggerContext _context;

       public ArticleCategoryRepository(MasterBloggerContext context)
       {
           _context = context;
       }

       public List<ArticleCategory> GetAll()
       {
           return _context.ArticleCategories.ToList();
       }

       public void Add(ArticleCategory entity)
       {
           _context.ArticleCategories.Add(entity);
           Save();
       }

        public ArticleCategory GetById(long id)
        {
            return _context.ArticleCategories.FirstOrDefault(x => x.Id == id);
        }

        public bool IsExist(string title)
        {
            return _context.ArticleCategories.Any(x => x.Title==title);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
   }
}
