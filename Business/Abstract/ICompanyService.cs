using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        List<Company> GetAll();
        Company GetById(int companyId);
        void Add(Company company);
        void Update(Company company);
        void Delete(Company company);
    }
}
