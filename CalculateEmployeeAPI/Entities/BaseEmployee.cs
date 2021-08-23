using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEmployeeAPI.Entities
{
    public abstract class BaseEmployee
    {
        [Key]
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
       
        private decimal Sallary2;
        public virtual decimal Sallary { get { return Sallary2; } set { Sallary2 = MaasHesapla(); } }
        //public decimal Sallary { get; set; }
        //public decimal Sallary { get; }
        public abstract decimal MaasHesapla();
    }
}
