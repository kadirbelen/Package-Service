using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public void Add(Company company)
        {
            _companyDal.Add(company);
        }

        public void Delete(Company company)
        {
            _companyDal.Delete(company);

        }

        public List<Company> GetAll()
        {
            return _companyDal.GetAll();
        }

        public Company GetById(int companyId)
        {
            return _companyDal.Get(p => p.Id == companyId);
        }



        public void Update(Company company)
        {
            _companyDal.Update(company);

        }
    }
}
