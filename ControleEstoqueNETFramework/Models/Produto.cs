using System.ComponentModel.DataAnnotations;

namespace ControleEstoqueNETFramework.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Nome { get; set; }

        [Required, Range(100, double.MaxValue)]
        public float Preco { get; set; }

        public CategoriaProduto Categoria { get; set; }

        [Required, StringLength(1500)]
        public string Descricao { get; set; }

        [Required, Range(0, int.MaxValue)]
        public int Quantidade { get; set; }

        public Produto()
        {
            Categoria = new CategoriaProduto();
        }
    }
}
