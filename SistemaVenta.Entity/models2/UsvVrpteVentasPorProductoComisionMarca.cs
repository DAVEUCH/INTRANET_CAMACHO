using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVrpteVentasPorProductoComisionMarca
    {
        public DateTime Fecha { get; set; }
        public string NumeroComprobante { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public int SucursalId { get; set; }
        public int VendedorId { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public string? ClaseProductoDescripcion { get; set; }
        public string? Marca { get; set; }
        public decimal? ValorComisión { get; set; }
        public decimal? ValorVentaSoles { get; set; }
        public decimal? ValorComisiónS { get; set; }
    }
}
