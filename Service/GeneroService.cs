namespace libreria.Service;



public class GeneroService : IGeneroService {
//Inyeccion de dependencias.
libreriaContext context;

public GeneroService(libreriaContext DbContext) => context = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(Genero inputGenero ){
   await context.AddAsync(inputGenero);
    await context.SaveChangesAsync();
}


    //READ - obtener de la db 
    public IEnumerable<Genero> obtener() => context.Genero;

    //UPDATE
    public async Task Actualizar(Guid id, Autor inputGenero){
    var Genero = context.Genero.Find(id);
    if(Genero != null){
        Genero.Nombre = inputGenero.Nombre;
        await context.SaveChangesAsync();
    }
}




public async Task eliminar(Guid id){
    var Genero = context.Genero.Find(id);
    if(Genero!= null){
        context.Remove(Genero);
        await context.SaveChangesAsync();
    }
}

public async Task<bool> ExisteAutor(Guid GeneroId) {
    var autor = await context.Genero.FindAsync(GeneroId);
    return autor != null;
}

    public Task Actualizar(Guid id, Genero autor)
    {
        throw new NotImplementedException();
    }
}


public interface IGeneroService{
Task insertar(Genero inputAutor);
IEnumerable<Genero> obtener();
Task Actualizar(Guid id, Genero autor);
Task eliminar(Guid Id);

}