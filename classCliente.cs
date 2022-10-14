public class Cliente : Persona
{
    private string datosReferenciaDireccion;

    public string DatosReferenciaDireccion { get => datosReferenciaDireccion; set => datosReferenciaDireccion = value; }

    public Cliente() : base() 
    {

    }

    public Cliente(int _idCliente, string _nombreCliente, string _direccionCliente, string _telefonoCliente, string _datosReferenciaDireccionCliente)
    {
        this.Id = _idCliente;
        this.Nombre = _nombreCliente;
        this.Direccion = _direccionCliente;
        this.Telefono = _telefonoCliente;
        this.DatosReferenciaDireccion = _datosReferenciaDireccionCliente;
        
    }
}