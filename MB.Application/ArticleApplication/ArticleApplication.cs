using System;
using System.Collections.Generic;
using System.Text;
using MB.Application.Contracts.ArticleViewModel;
using MB.Application.Contracts.IArticleApplication;
using MB.Domain.IRepository;

namespace MB.Application.ArticleApplication
{
    public class ArticleApplication:IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleApplication(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public List<ArticleViewModel> List()
        {
          return  _articleRepository.GetList();
        }
    }
}
