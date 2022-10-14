public class Cadeteria
{
    private string nombre;
    private string telefono;
    private List<Cadete> listadoCadetes = new List<Cadete>();

    public string Nombre { get => nombre; set => nombre = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }
    
    public Cadeteria(string _nombreCadeteria, string _telefonoCadeteria)
    {
        this.Nombre = _nombreCadeteria;
        this.Telefono = _telefonoCadeteria;
        this.ListadoCadetes = ListadoCadetes;
    
    }

}