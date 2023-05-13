using Microsoft.AspNetCore.Mvc;
namespace libreria.MapControllers;

//atributos para los controles
[ApiController]
[Route("[Controller]")]

public class LibrosController: ControllerBase{
//Atributos para la clase


[HttpPost]
public IActionResult PostLibros([FromBody] Libros newLibro){
return Ok();
}

[HttpGet]
public IActionResult GetLibros(){
return Ok();
}


[HttpPut("{id}")]
public IActionResult UpdateLibros(){
return Ok();
}


[HttpDelete("{id}")]
public IActionResult DeleteLibros(){
return Ok();
}

}
