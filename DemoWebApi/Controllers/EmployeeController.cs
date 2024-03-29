using DemoWebApi.Data;
using DemoShared.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public EmployeeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<EmployeesModel>>> getAllEmployee()
        {
            var employees = await _dataContext.Employees.ToListAsync();
            return Ok(employees);
        }
    }
}
