using System;
using System.Collections.Generic;
using System.Text;
using MB.Domain.Services;

namespace MB.Domain.ArticleCategory
{
    public class ArticleCategory
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTimeOffset CreationDate { get; private set; }

        public ArticleCategory(string title,IArticleCategoryValidationServic validation)
        {
            NullOrEmpty(title);
            validation.CheckThatReadyExits(title);

            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }

        public void Rename(string title)
        {
            NullOrEmpty(title);
            
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

        public void NullOrEmpty(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception();
            }
        }
    }
}
