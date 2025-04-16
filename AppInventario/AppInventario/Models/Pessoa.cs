using System.ComponentModel.DataAnnotations.Schema;
namespace AppInventario.Models
{
    [Table("pessoa")]
    public class Pessoa
    {
        [Column("i")]
        public int? Id { get; set; }

        [Column("nome")]
        public string? Nome { get; set; }

        [Column("cpf")]
        public string? Cpf { get; set; }

        [Column("data_nascimento")]
        public DateTime? DataNasc { get; set; }

        [Column("telefone")]
        public string? Telefone { get; set; }
        
        public List<Propriedade> Propriedade { get; set;}
    }
}
