
using CalculateEmployeeAPI.Entities;
using CalculateEmployeeAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateEmployeeAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository<FreeTimeEmployee> _freeTimeReposiyory;
        private readonly IEmployeeRepository<FullTimeEpmloyee> _fullTimeRepository;
        private readonly IEmployeeRepository<OverTimeEmployee> _overTimeReposiyory;

        public EmployeeController(IEmployeeRepository<FreeTimeEmployee> freeTimeReposiyory, IEmployeeRepository<FullTimeEpmloyee> fullTimeRepository, IEmployeeRepository<OverTimeEmployee> overTimeReposiyory)
        {
            _freeTimeReposiyory = freeTimeReposiyory;
            _fullTimeRepository = fullTimeRepository;
            _overTimeReposiyory = overTimeReposiyory;
        }
        [HttpGet("GetFreeTimeEmployee")]
        public IActionResult GetFreeTimeEmployee()
        {

            return Ok(_freeTimeReposiyory.Get());
        }
        [HttpGet("GetFullTimeEmployee")]
        public IActionResult GetFullTimeEmployee() {

            return Ok(_fullTimeRepository.Get());
        }
        [HttpGet("GetOverTimeEmployee")]
        public IActionResult GetOverTimeEmployee() {

            return Ok(_overTimeReposiyory.Get());
        }
        [HttpPost("PostFreeTimeEmployee")]
        public IActionResult PostFreeTimeEmployee(FreeTimeEmployee freeTimeEmployee)
        {
            _freeTimeReposiyory.Insert(freeTimeEmployee);
            return Ok();
        }
        [HttpPost("PostFullTimeEmployee")]
        public IActionResult PostFullTimeEmployee(FullTimeEpmloyee fullTimeEpmloyee)
        {
            _fullTimeRepository.Insert(fullTimeEpmloyee);
            return Ok();
        }
        [HttpPost("PostOverTimeEmployee")]
        public IActionResult PostOverTimeEmployee(OverTimeEmployee overTimeEmployee)
        {
            _overTimeReposiyory.Insert(overTimeEmployee);
            return Ok();
        }
    }
}
