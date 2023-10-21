using ComputacionClase2_ChavezClara.Dtos;
using ComputacionClase2_ChavezClara.Model;
using ComputacionClase2_ChavezClara.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComputacionClase2_ChavezClara.Controllers
{
    [ApiController]
    [Route("api/branches")]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService _branchService;

        public BranchController(IBranchService service)
        {
            _branchService = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_branchService.Get());
        }

        [HttpPost]
        public IActionResult Post([FromBody] SaveBranchDto dto)
        {
            _branchService.Save(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] SaveBranchDto dto)
        {
            _branchService.Update(id, dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _branchService.Delete(id);
            return Ok();
        }
    }
}
