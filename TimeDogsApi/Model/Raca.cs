using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeDogsApi.Model
{
    [Table("raca")]
    public class Raca
    {
        [Key]
        public int id { get; private set; }
        public string name { get; private set; }
        public string? apresentacao { get; private set; }
        public string? sobre { get; private set; }

        public Raca(string name, string apresentacao, string sobre)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.apresentacao = apresentacao;
            this.sobre = sobre;
        }
    }
}
