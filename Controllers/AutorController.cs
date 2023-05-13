using libreria.Service;
using Microsoft.AspNetCore.Mvc;
namespace libreria.MapControllers;

//atributos para los controles
[ApiController]
[Route("[Controller]")]

public class AutorController: ControllerBase
{

        IAutorService autorService;
    public AutorController(IAutorService serviceAutor) => autorService = serviceAutor;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public IActionResult PostAutors([FromBody] Autor newAutor) {
    autorService.insertar(newAutor);
return Ok();

}
//Read
[HttpGet]
public IActionResult GetAutores() {

return Ok(autorService.obtener());
}

//Update
[HttpPut("{id}")]
public IActionResult UpdateAutores([FromBody] Autor autorActualizar, Guid id) {
    autorService.Actualizar(id,autorActualizar);
return Ok();
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteAutores(Guid id) {
return Ok(autorService.eliminar(id));
}




}