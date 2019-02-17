using Microsoft.AspNetCore.Mvc;
using SlipManagementApi.Database;
using SlipManagementApi.Models.Request;
using SlipManagementApi.Models.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SlipManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly Configuration _config;
        private readonly SqlContext _db;

        public EmployeesController(Configuration config, SqlContext db)
        {
            _config = config;
            _db = db;
        }

        [HttpPut]
        public async Task<ActionResult<EmployeeModel>> CreateEmployee([FromBody] CreateEmployeeModel model)
        {
            try
            {
                return Ok(await _db.CreateEmployee(model));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<ActionResult<IList<EmployeeModel>>> GetAllEmployees()
        {
            try
            {
                return Ok(await _db.GetAllEmployees());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("id")]
        public async Task<ActionResult<IList<EmployeeModel>>> GetEmployee([FromHeader] int id)
        {
            try
            {
                return Ok(await _db.GetEmployee(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("id")]
        public async Task<ActionResult<IList<EmployeeModel>>> UpdateEmployee([FromHeader] int id, [FromBody] UpdateEmployeeModel updateModel)
        {
            try
            {
                return Ok(await _db.UpdateEmployee(id, updateModel));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("id")]
        public async Task<ActionResult<EmployeeModel>> DeleteEmployee([FromHeader] int id)
        {
            try
            {
                return Ok(await _db.DeleteEmployee(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}