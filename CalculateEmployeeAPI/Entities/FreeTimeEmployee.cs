using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEmployeeAPI.Entities
{
    public class FreeTimeEmployee:BaseEmployee
    {
        public int Day { get; set; }
        
        public override decimal MaasHesapla()
        {
            return this.Day * base.Sallary;
           
        }
    }
}
