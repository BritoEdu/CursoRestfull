using CursoApiRestfull.Model.Base;

namespace CursoApiRestfull.Model
{
    public class Person : BaseEntity
    {
        public string Nome { get; set; } 
        public string Sobrenome { get; set; }
        public string Endereço { get; set; }
        public string Genero { get; set; }
    }
}
