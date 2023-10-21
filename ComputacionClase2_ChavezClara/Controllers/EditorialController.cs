using ComputacionClase2_ChavezClara.Dtos;
using ComputacionClase2_ChavezClara.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComputacionClase2_ChavezClara.Controllers
{
    [ApiController]
    [Route("api/editorials")]
    public class EditorialController : ControllerBase
    {
        private readonly IEditorialService _editorialService;

        public EditorialController(IEditorialService service)
        {
            _editorialService = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_editorialService.Get()); //Método Ok valida un proceso
        }

        [HttpPost] //Para la insercion 
        public IActionResult Post([FromBody] SaveEditorialDto dto)
        {
            _editorialService.Save(dto);
            return Ok();
        }

        [HttpPut("{id}")] //Para actualizar solicitando el id
        public IActionResult Put(int id, [FromBody] SaveEditorialDto dto)
        {
            _editorialService.Update(id, dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _editorialService.Delete(id);
            return Ok();
        }
    }
}
