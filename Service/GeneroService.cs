namespace libreria.Service;



public class GeneroService : IGeneroService {
//Inyeccion de dependencias.
libreriaContext context1;

public GeneroService(libreriaContext DbContext) => context1 = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(Genero inputGenero ){
   await context1.AddAsync(inputGenero);
    await context1.SaveChangesAsync();
}


    //READ - obtener de la db 
    public IEnumerable<Genero> obtener() => context1.Genero;

    //UPDATE
    public async Task Actualizar(Guid id, Autor inputGenero){
    var Genero = context1.Genero.Find(id);
    if(Genero != null){
        Genero.Nombre = inputGenero.Nombre;
        await context1.SaveChangesAsync();
    }
}




public async Task eliminar(Guid id){
    var Genero = context1.Genero.Find(id);
    if(Genero!= null){
        context1.Remove(Genero);
        await context1.SaveChangesAsync();
    }
}

public async Task<bool> ExisteAutor(Guid GeneroId) {
    var autor = await context1.Genero.FindAsync(GeneroId);
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