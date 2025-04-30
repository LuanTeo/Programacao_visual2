using System.ComponentModel.DataAnnotations.Schema;
namespace App_multas.Models

{
    [Table("multa")]
    public class Multa
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("descricao")]
        public string? Descricao { get; set; }
        [Column("valor_multa")]
        public string? ValorMulta { get; set; }
        [Column("id_veiculo")]
        public int IdVeiculo { get; set; }

        [ForeignKey("IdVeiculo")]
        public Veiculos? Veiculo { get; set; }
    }
}
