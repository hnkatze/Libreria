

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Libros{
[Key]
public Guid LibrosId{get; set;}= Guid.NewGuid();

[ForeignKey("AutorId")]
public Guid AutorId{get;set;}

[ForeignKey("GeneroId")]
public Guid GeneroId{get;set;}

[Required]
[MaxLength(100)]
public String Nombre{get; set;}

[Required]
public int Edicion{get; set;}

[Required]
public int Paginas{get;set;}

public virtual Autor autor {get;set;}
public virtual Genero Genero {get;set;}

}