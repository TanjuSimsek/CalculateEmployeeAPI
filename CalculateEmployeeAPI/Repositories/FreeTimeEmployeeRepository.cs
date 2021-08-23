using CalculateEmployeeAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEmployeeAPI.Repositories
{
    public class FreeTimeEmployeeRepository :IEmployeeRepository<FreeTimeEmployee>
    {
        private readonly CalculateEmployeeContext _dbContext;
        private DbSet<FreeTimeEmployee> table;
        

        public FreeTimeEmployeeRepository(CalculateEmployeeContext dbContext)
        {
            _dbContext = dbContext;
            table = _dbContext.FreeTimeEmployees;
        }
        public IQueryable<FreeTimeEmployee> Get()
        {
            return table;
        }

        public int Insert(FreeTimeEmployee entity)
        {
            table.Add(entity);
            return _dbContext.SaveChanges();
        }
    }
}
