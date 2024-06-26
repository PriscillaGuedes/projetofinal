namespace LojaFeminina.Models
{
    public class PedidoItem
    {
        public int PedidoItemId { get; set; }

        public int PedidoId { get; set; }
        public virtual Pedido? Pedido { get; set; }

        public int ProdutoId { get; set; }
        public virtual Produto? Produto { get; set; }

        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
    }
}
