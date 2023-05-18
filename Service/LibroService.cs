namespace libreria.Service;



public class LibroService : ILibroService {
//Inyeccion de dependencias.
libreriaContext contextl;

public LibroService(libreriaContext DbContext) => contextl = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(Libros inputLibros ){
   await contextl.AddAsync(inputLibros);
    await contextl.SaveChangesAsync();
}


    //READ - obtener de la db 
    public IEnumerable<Libros> obtener() => contextl.Libros;

    //UPDATE
    public async Task Actualizar(Guid id, Libros inputLibros){
        try{
            var Libros = contextl.Libros.Find(id);
            if(Libros != null){
        Libros.Nombre = inputLibros.Nombre;
        Libros.Paginas = inputLibros.Paginas;
        Libros.Edicion = inputLibros.Edicion;
        await contextl.SaveChangesAsync();
    }


        }
        catch(Exception x){
            Console.WriteLine("Error al actualizar" + x.Message);
        }
   
}




public async Task eliminar(Guid id){
    var Libros = contextl.Libros.Find(id);
    if(Libros != null){
        contextl.Remove(Libros);
        await contextl.SaveChangesAsync();
    }
}

public async Task<bool> ExisteAutor(Guid LibrosId) {
    var Libros = await contextl.Libros.FindAsync(LibrosId);
    return Libros != null;
}
}


public interface ILibroService{
Task insertar(Libros inputAutor);
IEnumerable<Libros> obtener();
Task Actualizar(Guid id, Libros autor);
Task eliminar(Guid Id);

}