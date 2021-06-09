using System;
using System.Collections.Generic;
using System.Text;
using MB.Domain.Services;


namespace MB.Domain.ArticleCategory
{
    public class ArticleCategory
    {
        protected ArticleCategory()
        {
            
        }
        public long Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }
        public IEnumerable<Article.Article> Articles { get; set; }



        public ArticleCategory(string title,IArticleCategoryValidationServices validationServices)
        {
            GuardAgainstEmptyTitle(title);
            validationServices.CheckThatReadyExist(title);
             
            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
            Articles = new List<Article.Article>();
        }

        public void Rename(string title)
        {
            GuardAgainstEmptyTitle(title);
            Title = title;
        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void IsActive()
        {
            IsDeleted = false;
        }

        public void GuardAgainstEmptyTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception();
            }
        }
    }
}
