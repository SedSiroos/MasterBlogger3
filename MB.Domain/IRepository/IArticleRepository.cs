using System;
using System.Collections.Generic;
using System.Text;
using MB.Application.Contracts.ArticleViewModel;

namespace MB.Domain.IRepository
{
    public interface IArticleRepository
    {
        List<ArticleViewModel> GetList();
    }
}
