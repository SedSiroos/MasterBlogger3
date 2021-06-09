using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.Services
{
    public interface IArticleCategoryValidationServices
    {
        void CheckThatReadyExist(string title);
    }
}
