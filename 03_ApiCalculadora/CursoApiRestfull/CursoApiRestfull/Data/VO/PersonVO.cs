using CursoApiRestfull.Model.Base;

namespace CursoApiRestfull.Data.VO;

public class PersonVO
{
    public int Id { get; set; }
    public string Nome { get; set; } 
    public string Sobrenome { get; set; }
    public string Endereço { get; set; }
    public string Genero { get; set; }
}
