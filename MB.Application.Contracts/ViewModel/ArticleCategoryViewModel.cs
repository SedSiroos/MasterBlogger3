using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Application.Contracts.ViewModel
{
    public class ArticleCategoryViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
