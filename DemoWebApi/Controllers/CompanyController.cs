using DemoWebApi.Data;
using DemoShared.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public CompanyController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<CompanyModel>>> getAllCompany()
        {
            var company = await _dataContext.Companies.ToListAsync();
            return Ok(company);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyModel>> getCompany(string id)
        {
            var company = await _dataContext.Companies.FindAsync(id);
            if (company is null)
            {
                return NotFound("Company not found !");
            }
            return Ok(company);
        }

        [HttpPost]
        public async Task<ActionResult<CompanyModel>> AddCompany(CompanyModel company)
        {
            company.created_at = DateTime.Now;
            _dataContext.Companies.Add(company);
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Companies.ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CompanyModel>> UpdateCompany(string id, CompanyModel updateCompany)
        {
            if (id != updateCompany.company_id)
            {
                return BadRequest("Id mismatch!");
            }

            var existingCompany = await _dataContext.Companies.FindAsync(id);
            if (existingCompany == null)
            {
                return NotFound("Company not found !");
            }

            // Kiểm tra xem companyId đã được thay đổi chưa
            if (existingCompany.company_id != updateCompany.company_id)
            {
                return BadRequest("CompanyId cannot be changed!");
            }

            // Cập nhật các trường dữ liệu khác của công ty
            existingCompany.company_name = updateCompany.company_name;
            existingCompany.created_at = updateCompany.created_at;
            existingCompany.updated_at = DateTime.Now;

            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Companies.ToListAsync());
        }


        [HttpDelete]
        public async Task<ActionResult<CompanyModel>> DeleteCompany(string id)
        {
            var company = await _dataContext.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound("Company not found !");
            }
            _dataContext.Companies.Remove(company);
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Companies.ToListAsync());
        }
    }
}
