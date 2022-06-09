namespace ExemploListaOrientacaoObjeto.Exemplos
{
    public class Produto
    {
        public int Codigo, Quantidade;
        public string Nome;
        public double PrecoUnitario;
        public ProdutoLocalizacao Localizacao;

        public double CalcularPrecoTotal()
        {
            var preco = Quantidade * PrecoUnitario;

            return preco;
        }
    }
}
