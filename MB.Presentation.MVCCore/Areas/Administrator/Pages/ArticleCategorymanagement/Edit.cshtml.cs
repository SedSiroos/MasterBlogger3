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
    public class EditModel : PageModel
    {
        private readonly IArticleCategoryApllication _articleCategoryApllication;

        public EditModel(IArticleCategoryApllication articleCategoryApllication)
        {
            _articleCategoryApllication = articleCategoryApllication;
        }

        [BindProperty]
        public RenameArticleCategoryViewModle ArticleCategory { get; set; }
        public void OnGet(long id)
        {
            ArticleCategory = _articleCategoryApllication.GetRenameById(id);
        }

        public RedirectToPageResult OnPost()
        {
            _articleCategoryApllication.Rename(ArticleCategory);
            return RedirectToPage("./List");
            
        }
    }
}
