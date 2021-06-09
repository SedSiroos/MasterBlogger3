using System;
using System.Collections.Generic;
using System.Text;
using MB.Domain.IRepository;

namespace MB.Domain.Services
{
    public class ArticleCategoryValidationService:IArticleCategoryValidationServices
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryValidationService(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        public void CheckThatReadyExist(string title)
        {
            _articleCategoryRepository.IsExist(title);
        }
    }
}
