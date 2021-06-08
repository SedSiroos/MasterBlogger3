using System;
using System.Collections.Generic;
using System.Text;
using MB.Application.Contracts.ViewModel;

namespace MB.Application.Contracts.IArticleCategory
{
   public interface IArticleCategoryApllication
   {
       List<ArticleCategoryViewModel> List();
       void Create(CreateArticleCategoryViewModle command);
       RenameArticleCategoryViewModle GetRenameById(long id);
       void Rename(RenameArticleCategoryViewModle rename);
       void Remove(long id);
       void IsActive(long id);
   }
}
