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
    public class CreateModel : PageModel
    {
        private readonly IArticleCategoryApllication _articleCategoryApllication;

        public CreateModel(IArticleCategoryApllication articleCategoryApllication)
        {
            _articleCategoryApllication = articleCategoryApllication;
        }

        public List<CreateArticleCategoryViewModle> CreateArticleCategory { get; set; }
        public void OnGet()
        {
            
        }
        public RedirectToPageResult OnPost(CreateArticleCategoryViewModle command)
        {
             _articleCategoryApllication.Create(command);
             return RedirectToPage("./List");
        }
    }
}
