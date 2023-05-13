using Microsoft.EntityFrameworkCore;
namespace libreria;


public class libreriaContext: DbContext {

public DbSet<Autor>? Autor {get;set;}


public libreriaContext(DbContextOptions<libreriaContext> options) : base(options){}
}