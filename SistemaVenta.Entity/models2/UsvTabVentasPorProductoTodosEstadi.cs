using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvTabVentasPorProductoTodosEstadi
    {
        public string? Año { get; set; }
        public int Idperiodo { get; set; }
        public int? ClienteId { get; set; }
        public string? TipoClienteDescripcion { get; set; }
        public int? TransacVentas { get; set; }
        public int? NumItems { get; set; }
        public int? CantidadProductos { get; set; }
        public int? UnidadesVendidas { get; set; }
        public decimal? ImpVentasAñoSol { get; set; }
        public decimal? ImpVentasAñoDol { get; set; }
    }
}
