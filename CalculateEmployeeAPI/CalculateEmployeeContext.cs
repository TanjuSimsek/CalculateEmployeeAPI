using CalculateEmployeeAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEmployeeAPI
{
    public class CalculateEmployeeContext: DbContext
    {
        public CalculateEmployeeContext(DbContextOptions<CalculateEmployeeContext> options) : base(options)
        {

        }
        public DbSet<FullTimeEpmloyee> FullTimeEmployee { get; set; }
        public DbSet<FreeTimeEmployee> FreeTimeEmployees { get; set; }
        public DbSet<OverTimeEmployee> OverTimeEmployees { get; set; }

    }
}
