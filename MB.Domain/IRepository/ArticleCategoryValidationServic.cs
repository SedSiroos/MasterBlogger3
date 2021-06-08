using System;
using System.Collections.Generic;
using System.Text;
using MB.Domain.Services;

namespace MB.Domain.IRepository
{
    public class ArticleCategoryValidationServic: IArticleCategoryValidationServic
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryValidationServic(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        public void CheckThatReadyExits(string title)
        {
            if (_articleCategoryRepository.IsExist(title))
            {
                throw new Exception();
            }
        }
    }
}
