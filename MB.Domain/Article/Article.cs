using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MB.Domain.Article
{
    public class Article
    {
        protected Article()
        {
            
        }

        [Key]
        public long Id { get; private set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; private set; }

        [Required]
        [MaxLength(1000)]
        public string ShortDescription { get; private set; }

        public string Image { get; private set; }

        public string Content { get; private set; }
        public bool IsDeleted { get; private set; }
        public long ArticleCategoryId { get; private set; }
        public DateTime CreationDate { get; private set; }
        public ArticleCategory.ArticleCategory ArticleCategory { get; private set; }


        public Article(string title, string shortDescription, string image, string content,long articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            IsDeleted = false;
            CreationDate=DateTime.Now;
            ArticleCategoryId = articleCategoryId;
        }
    }
}
