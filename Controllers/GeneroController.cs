using Microsoft.AspNetCore.Mvc;
namespace libreria.MapControllers;

//atributos para los controles
[ApiController]
[Route("[Controller]")]

public class GeneroController: ControllerBase{
//Atributos para la clase


[HttpPost]
public IActionResult PostGenero([FromBody] Genero newGenero){
return Ok();
}

[HttpGet]
public IActionResult GetGenero(){
return Ok();
}


[HttpPut("{id}")]
public IActionResult UpdateGenero(){
return Ok();
}


[HttpDelete("{id}")]
public IActionResult DeleteGenero(){
return Ok();
}

}
