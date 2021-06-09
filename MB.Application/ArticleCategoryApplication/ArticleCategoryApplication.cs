using MB.Application.Contracts.IArticleCategory;
using System;
using System.Collections.Generic;
using System.Text;
using MB.Application.Contracts.ViewModel;
using MB.Domain.ArticleCategory;
using MB.Domain.IRepository;
using MB.Domain.Services;

namespace MB.Application.ArticleCategoryApplication
{
    public class ArticleCategoryApplication : IArticleCategoryApllication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidationServices _articleCategoryValidation;
        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository, IArticleCategoryValidationServices articleCategoryValidation)
        {
            _articleCategoryRepository = articleCategoryRepository;
            _articleCategoryValidation = articleCategoryValidation;
        }

        public List<ArticleCategoryViewModel> List()
        {
            var articalCategories= _articleCategoryRepository.GetAll();

            var result = new List<ArticleCategoryViewModel>();

            foreach (var item in articalCategories)
            {
                result.Add(new ArticleCategoryViewModel
                {
                    Id = item.Id,
                    Title = item.Title,
                    IsDeleted = item.IsDeleted,
                    CreationDate = item.CreationDate,
                });
            }

            return result;
        }

        public void Create(CreateArticleCategoryViewModle command)
        {
            var add = new ArticleCategory(command.Title, _articleCategoryValidation);
            _articleCategoryRepository.Add(add);
        }

        public RenameArticleCategoryViewModle GetRenameById(long id)
        {
            var article = _articleCategoryRepository.GetById(id);
            return new RenameArticleCategoryViewModle
            {
                Id = article.Id,
                Title = article.Title
            };
        }

        public void Rename(RenameArticleCategoryViewModle rename)
        {
            var article = _articleCategoryRepository.GetById(rename.Id);

            article.Rename(rename.Title);
            _articleCategoryRepository.Save();
        }

        public void Remove(long id)
        {
            var getId = _articleCategoryRepository.GetById(id);
            getId.Remove();
            _articleCategoryRepository.Save();
        }

        public void IsActive(long id)
        {
            var getId = _articleCategoryRepository.GetById(id);
            getId.IsActive();
            _articleCategoryRepository.Save();
        }
    }
}
