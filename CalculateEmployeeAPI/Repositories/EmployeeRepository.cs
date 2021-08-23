using CalculateEmployeeAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEmployeeAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository<FullTimeEpmloyee>
    {
        private readonly CalculateEmployeeContext _dbContext;
        private DbSet<FullTimeEpmloyee> table;

        public EmployeeRepository(CalculateEmployeeContext dbContext)
        {
            _dbContext = dbContext;
            table = _dbContext.FullTimeEmployee;
        }

        public IQueryable<FullTimeEpmloyee> Get()
        {
            return table;
        }

        public int Insert(FullTimeEpmloyee entity)
        {
            table.Add(entity);
            return _dbContext.SaveChanges();
        }
    }
}
