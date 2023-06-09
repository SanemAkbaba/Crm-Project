﻿using Company.Crm.Domain.Entities;
using Company.Framework.Repository;

namespace Company.Crm.Domain.Repositories;

public interface IEmployeeRepository : IRepository<Employee>
{
    public List<Employee> GetAllByRegionId(int regionId);
}