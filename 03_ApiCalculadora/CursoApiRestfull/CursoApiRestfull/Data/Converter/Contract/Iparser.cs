namespace CursoApiRestfull.Data.Converter.Contract
{
    public interface Iparser<O,D>
    {
        D Parse(O origin);  
        List<D> Parse(List<O> origin);
    }
}
