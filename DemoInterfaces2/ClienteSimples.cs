public class ClienteSimples : ICliente
{
    public string Nome { get; }

    public DateTime? UltimaCompra { get; private set; }

    public DateTime DataCadastro { get; }

    public IEnumerable<IPedido> PedidosAnteriores => ;

    private List<IPedido> todosPedidos = new List<IPedido>();
}