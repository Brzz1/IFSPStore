

using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    internal class Produto : BaseEntity<int>
    {
        public Produto() { }

        public Produto(int id, string nome, decimal preco, int quantidade, DateOnly dataCompra, string unidadeVenda, Grupo grupo) 
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
            this.DataCompra = dataCompra;
            this.UnidadeVenda = unidadeVenda;
            this.Grupo = grupo;
        }

        public string? Nome { get; set; }

        public decimal? Preco { get; set; }

        public int? Quantidade { get; set; }

        public DateOnly? DataCompra { get; set; }

        public string? UnidadeVenda { get; set; }

        public Grupo Grupo { get; set; }

    }
}
