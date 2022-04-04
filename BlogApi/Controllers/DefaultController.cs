using BlogApi.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("list")]
        public IActionResult EmployeeList()
        {
            using var c = new ApiContext();
            var values = c.Employees.ToList();
            return Ok(values);
        }
        [HttpPost("add")]
        public IActionResult EmployeeAdd(Employee employee)
        {
            using var c = new ApiContext();
            c.Add(employee);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("getbyid{id}")]
        public IActionResult EmployeeGet(int id)
        {
            using var c = new ApiContext();
            var employee = c.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpDelete("delete{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            using var c = new ApiContext();
            var employee = c.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            c.Remove(employee);
            c.SaveChanges();
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult EmployeeUpdate(Employee employee)
        {
            using var c = new ApiContext();
            var emp = c.Employees.Find(employee.Id);
            if (employee == null)
            {
                return NotFound();
            }
            emp.Name = employee.Name;
            c.Update(emp);
            c.SaveChanges();
            return Ok();
        }
    }
}