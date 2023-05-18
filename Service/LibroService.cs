namespace libreria.Service;



public class LibroService : ILibroService {
//Inyeccion de dependencias.
libreriaContext context;

public LibroService(libreriaContext DbContext) => context = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(Libros inputLibros ){
   await context.AddAsync(inputLibros);
    await context.SaveChangesAsync();
}


    //READ - obtener de la db 
    public IEnumerable<Libros> obtener() => context.Libros;

    //UPDATE
    public async Task Actualizar(Guid id, Libros inputLibros){
        try{
            var Libros = context.Libros.Find(id);
            if(Libros != null){
        Libros.Nombre = inputLibros.Nombre;
        Libros.Paginas = inputLibros.Paginas;
        Libros.Edicion = inputLibros.Edicion;
        await context.SaveChangesAsync();
    }


        }
        catch(Exception x){
            Console.WriteLine("Error al actualizar" + x.Message);
        }
   
}




public async Task eliminar(Guid id){
    var Libros = context.Libros.Find(id);
    if(Libros != null){
        context.Remove(Libros);
        await context.SaveChangesAsync();
    }
}

public async Task<bool> ExisteAutor(Guid LibrosId) {
    var Libros = await context.Libros.FindAsync(LibrosId);
    return Libros != null;
}
}


public interface ILibroService{
Task insertar(Libros inputAutor);
IEnumerable<Libros> obtener();
Task Actualizar(Guid id, Libros autor);
Task eliminar(Guid Id);

}