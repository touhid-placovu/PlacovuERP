using Placovu.Erp.EntityModel;
using Placovu.Erp.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.Repository
{
    public class BSECompanyRepository : IBSECompanyRepository
    {
        private readonly PlacovuEntityContext _dbContext;

        public BSECompanyRepository(PlacovuEntityContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<BSECompany> GetBSECompany()
        {
            return  _dbContext.BSECompanies.ToList();
        }

        public Task<BSECompany> GetBSECompany(int companyID)
        {
            return _dbContext.BSECompanies.FindAsync(companyID);
        }

        public Task<int> InsertBSECompanyAsync(BSECompany bSECompany)
        {
            _dbContext.BSECompanies.Add(bSECompany);
            return _dbContext.SaveChangesAsync();
        }

        public Task<int> UpdateBSECompanyAsync(BSECompany bSECompany)
        {
            var original = _dbContext.BSECompanies.Find(bSECompany.CompanyID);
            _dbContext.Entry(original).CurrentValues.SetValues(bSECompany);
            return _dbContext.SaveChangesAsync();
        }
    }
}
