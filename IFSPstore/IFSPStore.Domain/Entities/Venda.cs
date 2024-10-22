

using IFSPStore.Domain.Base;
using System.Text.Json.Serialization;

namespace IFSPStore.Domain.Entities
{
    public class Venda : BaseEntity<int>
    {
        public Venda() 
        {
            Items = new List<VendaItem>();
        }

        public Venda(int id, DateTime data, float valorTotal, Usuario? usuario, Cliente? cliente,
            List<VendaItem> items) : base(id) 
        { 
            Data = data;
            ValorTotal = valorTotal;
            Usuario = usuario;
            Cliente = cliente;
            Items = items;
        }

        public DateTime Data { get; set; }
        public float ValorTotal { get; set; }
        public Usuario? Usuario { get; set; }
        public Cliente? Cliente { get; set; }
        public virtual List<VendaItem> Items { get; set; }


    }

    public class VendaItem : BaseEntity<int> 
    {

        public VendaItem() 
        {

        }

        public VendaItem(int id, int quantidade, float valorUnitario, float valorTotal, Venda? venda) 
        {
            Id = id;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            ValorTotal = valorTotal;
            Venda = venda;
        }

        public int Quantidade { get; set; }
        public float ValorUnitario { get; set; }
        public float ValorTotal { get; set; }
        [JsonIgnore]
        public virtual Venda? Venda { get; set; }

    }

}
