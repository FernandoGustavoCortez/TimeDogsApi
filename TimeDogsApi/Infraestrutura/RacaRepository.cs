using TimeDogsApi.Model;

namespace TimeDogsApi.Infraestrutura
{
    public class RacaRepository : IRacaRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Raca raca)
        {
            _context.Racas.Add(raca);
            _context.SaveChanges();
        }

        public List<Raca> Get()
        {
            return _context.Racas.ToList();
        }

        public Raca? GetRaca(int id)
        {
            return _context.Racas.Find(id);
        }
    }
}
