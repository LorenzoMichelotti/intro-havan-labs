namespace Data
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {
            Nome = "Produto Teste";
            Descricao = "Isso é um produto de teste";
            Quantidade = 1;
        }
    }
}