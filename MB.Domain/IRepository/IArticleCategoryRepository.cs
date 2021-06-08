using System;
using System.Collections.Generic;
using System.Text;
using MB.Domain.ArticleCategory;

namespace MB.Domain.IRepository
{
    public interface IArticleCategoryRepository
    {
        List<ArticleCategory.ArticleCategory> GetAll();
        void Add(ArticleCategory.ArticleCategory entity);
        ArticleCategory.ArticleCategory GetById(long id);
        bool IsExist(string title);
        void Save();
    }
}
