using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.Services
{
    public interface IArticleCategoryValidationServic
    {
        void CheckThatReadyExits(string title);
    }
}
