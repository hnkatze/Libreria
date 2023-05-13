namespace libreria.Service;



public class AutorService : IAutorService {
//Inyeccion de dependencias.
libreriaContext context;

public AutorService(libreriaContext DbContext) => context = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(Autor inputAutor ){
    inputAutor.AutorId = Guid.NewGuid();
   await context.AddAsync(inputAutor);
    await context.SaveChangesAsync();
}


//READ - obtener de la db 
public IEnumerable<Autor>? obtener(){
return context.Autor;

}

//UPDATE
public async Task Actualizar(Guid id, Autor inputAutor){
    var autor = context.Autor.Find(id);
    if(autor != null){
        autor.Nombre = inputAutor.Nombre;
        autor.Apellido = inputAutor.Apellido;
        autor.Nacionalidad = inputAutor.Nacionalidad;
        await context.SaveChangesAsync();
    }
}


public async Task eliminar(Guid id){
    var autor = context.Autor.Find(id);
    if(autor != null){
        context.Remove(autor);
        await context.SaveChangesAsync();
    }
}

}


public interface IAutorService{
Task insertar(Autor inputAutor);
IEnumerable<Autor> obtener();
Task Actualizar(Guid id, Autor autor);
Task eliminar(Guid Id);

}