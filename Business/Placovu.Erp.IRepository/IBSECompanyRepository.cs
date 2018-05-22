
using Placovu.Erp.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.IRepository
{
    public interface IBSECompanyRepository
    {
        IEnumerable<BSECompany> GetBSECompany();
        Task<BSECompany> GetBSECompany(int companyID);
        Task<int> InsertBSECompanyAsync(BSECompany bSECompany);
        Task<int> UpdateBSECompanyAsync(BSECompany bSECompany);
    }
}
