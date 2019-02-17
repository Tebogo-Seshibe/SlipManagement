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
    public class SlipsController : ControllerBase
    {
        private readonly Configuration _config;
        private readonly SqlContext _db;

        public SlipsController(Configuration config, SqlContext db)
        {
            _config = config;
            _db = db;
        }

        [HttpPut]
        public async Task<ActionResult<SlipModel>> CretaeModel([FromBody] CreateSlipModel model)
        {
            try
            {
                return Ok(await _db.CreateSlip(model));
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        [HttpGet]
        public async Task<ActionResult<IList<SlipModel>>> GetAllSlips()
        {
            try
            {
                return Ok(await _db.GetAllSlips());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("id")]
        public async Task<ActionResult<IList<SlipModel>>> GetSlip([FromHeader] int id)
        {
            try
            {
                return Ok(await _db.GetSlip(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("id")]
        public async Task<ActionResult<IList<SlipModel>>> UpdateSlip([FromHeader] int id, [FromBody] UpdateSlipModel updateModel)
        {
            try
            {
                return Ok(await _db.UpdateSlip(id, updateModel));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("id")]
        public async Task<ActionResult<SlipModel>> DeleteSlip([FromHeader] int id)
        {
            try
            {
                return Ok(await _db.DeleteSlip(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
