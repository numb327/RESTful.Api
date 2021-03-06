﻿using RESTful.API.DtoParmeters;
using RESTful.API.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RESTful.API.Services
{
    public interface ICompanyRepository
    {
        Task<Company> GetCompanyAsync(Guid companyId);
        Task<IEnumerable<Company>> GetCompaniesAsync(CompanyDtoParameters parameters);
        Task<IEnumerable<Company>> GetCompaniesAsync(IEnumerable<Guid> companyIds);
        void AddCompany(Company company);
        void UpdateCompany(Company company);
        void DeleteCompany(Company company);
        Task<bool> CompanyExistsAsync(Guid companyId);

        Task<Employee> GetEmployeeAsync(Guid companyId, Guid employeeId);
        Task<IEnumerable<Employee>> GetEmployeesAsync(Guid companyId, string genderDisplay, string q);
        void AddEmployee(Guid companyId, Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);

        Task<bool> SaveAsync();
    }
}
