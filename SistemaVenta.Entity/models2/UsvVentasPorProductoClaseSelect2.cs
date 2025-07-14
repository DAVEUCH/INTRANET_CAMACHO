using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoClaseSelect2
    {
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
        public int? IdclaseProductoServicio { get; set; }
        public string? ClaseCodigo { get; set; }
        public string? ClaseDescripcion { get; set; }
        public decimal? CantidadVendida { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? Total { get; set; }
    }
}
