using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeDogsApi.Model
{
    [Table("cachorro")]
    public class Cachorro
    {
        [Key]
        public int id { get; private set; }
        public string name { get; private set; }
        public string? sobre { get; private set; }
        public int id_raca { get; private set; }

        public Cachorro(string name, string sobre, int id_raca) 
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.sobre = sobre;
            this.id_raca = id_raca;
        }
    }
}
