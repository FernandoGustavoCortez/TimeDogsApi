using TimeDogsApi.Model;

namespace TimeDogsApi.Infraestrutura
{
    public class CachorroRepository :ICachorroRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public Cachorro? GetCachorro(int id)
        {
            var cachorro = _context.Cachorros.Find(id);
            return cachorro;
        }
    }
}
