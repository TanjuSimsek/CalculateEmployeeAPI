using CalculateEmployeeAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEmployeeAPI.Repositories
{
    public interface IEmployeeRepository<T> where T : BaseEmployee
    {
        public IQueryable<T> Get();

        public int Insert(T entity);
    }
}
