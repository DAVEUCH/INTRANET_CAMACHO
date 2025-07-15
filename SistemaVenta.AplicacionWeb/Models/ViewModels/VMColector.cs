namespace SistemaVenta.AplicacionWeb.Models.ViewModels
{
    public class VMColector
    {
        public string? Empresa { get; set; }
        public string? Almacen { get; set; }
        public string? Ubicacion { get; set; }
        public string? Producto { get; set; }
        public int Cantidad { get; set; }
        public string? Fecha { get; set; } // o DateTime si lo conviertes
    }
}
