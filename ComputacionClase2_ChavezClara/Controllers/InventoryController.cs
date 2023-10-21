using ComputacionClase2_ChavezClara.Dtos;
using ComputacionClase2_ChavezClara.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComputacionClase2_ChavezClara.Controllers
{
    [ApiController]
    [Route("api/inventories")]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService service)
        {
            _inventoryService = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_inventoryService.Get());
        }

        [HttpPost]
        public ActionResult Post([FromBody] SaveInventoryDto dto)
        {
            _inventoryService.Save(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] SaveInventoryDto dto)
        {
            _inventoryService.Update(id, dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _inventoryService.Delete(id);
            return Ok();
        }
    }
}
