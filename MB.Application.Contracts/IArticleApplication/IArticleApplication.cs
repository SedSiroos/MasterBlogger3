using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Application.Contracts.IArticleApplication
{
    public interface IArticleApplication
    {
        List<ArticleViewModel.ArticleViewModel> List();
    }
}
