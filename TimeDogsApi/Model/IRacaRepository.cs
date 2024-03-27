namespace TimeDogsApi.Model
{
    public interface IRacaRepository
    {
        void Add(Raca raca);
        List<Raca> Get();

        Raca? GetRaca(int id);
    }
}
