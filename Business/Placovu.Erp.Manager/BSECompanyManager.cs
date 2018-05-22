
using Placovu.Erp.EntityModel;
using Placovu.Erp.IManager;
using Placovu.Erp.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.Manager
{
   
    public class BSECompanyManager : IBSECompanyManager
    {
        private IBSECompanyRepository _iBSECompanyRepository;

        public BSECompanyManager(IBSECompanyRepository iBSECompanyRepository) {
            _iBSECompanyRepository = iBSECompanyRepository;
        }

        public IEnumerable<BSECompany> GetBSECompany()
        {
            return _iBSECompanyRepository.GetBSECompany();
        }
        public async Task<BSECompany> GetBSECompany(int companyID)
        {
            return await _iBSECompanyRepository.GetBSECompany(companyID);
        }
        public async Task<int> InsertBSECompanyAsync(BSECompany bSECompany)
        {
            return await _iBSECompanyRepository.InsertBSECompanyAsync(bSECompany);
        }
        public async Task<int> UpdateBSECompanyAsync(BSECompany bSECompany)
        {
            return await _iBSECompanyRepository.UpdateBSECompanyAsync(bSECompany);
        }
    }
}
