namespace ControleEstoqueNETFramework.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public CategoriaProduto Categoria { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {
            Categoria = new CategoriaProduto();
        }
    }
}
