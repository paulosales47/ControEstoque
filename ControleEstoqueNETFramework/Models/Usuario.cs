namespace ControleEstoqueNETFramework.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}" +
                   $", Nome: {Nome}" +
                   $", Senha: {Senha}";
        }
    }
}
