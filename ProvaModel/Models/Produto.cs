namespace ProvaModel.Models
{
    public class Produto
    {
        public long ProdutoId { get; set; }
        public long FornecedorId { get; set; } //Foreign Key de fornecedor
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Fornecedor Fornecedor { get; set; }   
    
    }
}