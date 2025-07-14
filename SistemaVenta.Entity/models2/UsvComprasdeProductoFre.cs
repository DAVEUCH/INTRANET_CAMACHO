using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvComprasdeProductoFre
    {
        public string Sucursal { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Proveedor { get; set; }
        public string? RucDniCliente { get; set; }
        public string TipoComprobante { get; set; } = null!;
        public string NroComprobante { get; set; } = null!;
        public string CodigoProducto { get; set; } = null!;
        public string DescripcionProducto { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public decimal? CostoSinIgvsoles { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal? CostoSinIgvdolares { get; set; }
    }
}
