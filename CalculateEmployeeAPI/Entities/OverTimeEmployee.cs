using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEmployeeAPI.Entities
{
    public class OverTimeEmployee:BaseEmployee
    {
        public decimal OverTimePay { get; set; }
        public int Hour { get; set; }
        public override decimal MaasHesapla()
        {
            return base.Sallary + (OverTimePay * Hour);
        }
    }
}
