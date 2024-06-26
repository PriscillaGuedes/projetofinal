using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LojaFeminina.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime DataPedido { get; set; }
        public double ValorTotal { get; set; }
        public string? Status { get; set; }

        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        public virtual ICollection<PedidoItem> ?PedidoItems { get; set; }
   
    }
}
