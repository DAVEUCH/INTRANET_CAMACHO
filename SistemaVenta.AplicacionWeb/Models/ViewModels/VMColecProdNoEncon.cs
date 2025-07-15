namespace SistemaVenta.AplicacionWeb.Models.ViewModels
{
    public class VMColecProdNoEncon
    {
        public string? Empresa { get; set; }
        public string? Almacen { get; set; }
        public string? Codigo { get; set; }
        public string? Ubicacion { get; set; }
        public int Cantidad { get; set; }
        public string? Fecha { get; set; } // o DateTime si lo conviertes
    }
}
