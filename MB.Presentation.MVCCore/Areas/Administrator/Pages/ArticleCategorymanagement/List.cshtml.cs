using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contracts.IArticleCategory;
using MB.Application.Contracts.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.ArticleCategorymanagement
{
    public class ListModel : PageModel
    {
        private readonly IArticleCategoryApllication _articleCategoryApllication;

        public ListModel(IArticleCategoryApllication articleCategoryApllication)
        {
            _articleCategoryApllication = articleCategoryApllication;
        }

        public List<ArticleCategoryViewModel> ArticleCategory { get; set; }
        public void OnGet()
        {
            ArticleCategory = _articleCategoryApllication.List();
        }

        public RedirectToPageResult OnPostRemove(long id)
        {
            _articleCategoryApllication.Remove(id);
            return RedirectToPage("./List");
        }

        public RedirectToPageResult OnPostIsActive(long id)
        {
            _articleCategoryApllication.IsActive(id);
            return RedirectToPage("./List");
        }
    }
}
