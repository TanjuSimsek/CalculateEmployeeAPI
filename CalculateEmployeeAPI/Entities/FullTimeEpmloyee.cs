using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEmployeeAPI.Entities
{
    public class FullTimeEpmloyee:BaseEmployee
    {
        
        public override decimal MaasHesapla()
        {
            return Sallary;
        }
    }
}
