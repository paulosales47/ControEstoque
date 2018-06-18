using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;

namespace ControleEstoqueNETFramework.Models
{
    public class CategoriaProduto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IList<Produto> Produtos { get; set; }

        public CategoriaProduto()
        {
            Produtos = new List<Produto>();
        }

    }
}
