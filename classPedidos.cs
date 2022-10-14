public class Pedidos
{
    private int numero;
    private string observaciones;
    private Cliente clientePedido;
    private string estado;

    public Pedidos () 
    {

    }

    public Pedidos(int _numeroPedido, string _observacionesPedido, Cliente _clientePedido, string _estadoPedido)
    {
        this.Numero = _numeroPedido;
        this.Observaciones = _observacionesPedido;
        this.ClientePedido = _clientePedido;
        this.Estado = _estadoPedido;
    }

    public int Numero { get => numero; set => numero = value; }
    public string Observaciones { get => observaciones; set => observaciones = value; }
    public Cliente ClientePedido { get => clientePedido; set => clientePedido = value; }
    public string Estado { get => estado; set => estado = value; }
}