using CalculateEmployeeAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEmployeeAPI.Repositories
{
    public class OverTimeEmployeeRepository : IEmployeeRepository<OverTimeEmployee>
    {
        private readonly CalculateEmployeeContext _dbContext;
        private DbSet<OverTimeEmployee> table;
        public OverTimeEmployeeRepository(CalculateEmployeeContext dbContext)
        {
            _dbContext = dbContext;
            table = _dbContext.OverTimeEmployees;
        }
        public IQueryable<OverTimeEmployee> Get()
        {
            return table;
        }

        public int Insert(OverTimeEmployee entity)
        {
            table.Add(entity);
            return _dbContext.SaveChanges();
        }
    }
}
