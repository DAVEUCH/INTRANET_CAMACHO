using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMovimientoEntradaInventario
    {
        public string Linea { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Anulado { get; set; }
        public int Pkid { get; set; }
        public decimal? Cantidad { get; set; }
        public string OrigenDestinoNombre { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Almacen { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
    }
}
