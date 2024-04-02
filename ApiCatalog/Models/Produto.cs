using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCatalog.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        [Required]
        [StringLength(30)]
        public string? Nome { get; set; } = string.Empty;
        [Required]
        [StringLength(300)]
        public string Descricao {  get; set; } = string.Empty;
        [Required]
        [Column(TypeName = "decimal(10,2")]
        public decimal Preco {  get; set; }
        [Required]
        [StringLength(300)]
        public string? ImagemURl { get; set; }
        public float Estoque { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int CategoriaId {  get; set; }
        public Categoria? Categoria { get; set; }
    }
}
