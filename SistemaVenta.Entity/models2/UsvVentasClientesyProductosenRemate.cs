using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasClientesyProductosenRemate
    {
        public DateTime Fecha { get; set; }
        public string TipoComprobante { get; set; } = null!;
        public string NroComprobante { get; set; } = null!;
        public int SucursalId { get; set; }
        public string Sucursal { get; set; } = null!;
        public int ClienteId { get; set; }
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public string DescripModalidadCredito { get; set; } = null!;
        public int ProductoId { get; set; }
        public string CodigoProducto { get; set; } = null!;
        public string DescripcionProducto { get; set; } = null!;
        public string MarcaDescripcion { get; set; } = null!;
        public string ClaseProductoDescripcion { get; set; } = null!;
        public int VendedorId { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public decimal? ValorVentaS { get; set; }
        public decimal? TotalS { get; set; }
        public decimal? ValorComisiónS { get; set; }
        public decimal? Cantidad { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public string UnidadReferencia { get; set; } = null!;
        public decimal DescuentoA { get; set; }
        public decimal DescuentoB { get; set; }
        public decimal ListaPrecioValorVenta { get; set; }
        public decimal ListaPrecioPrecioIncImpto { get; set; }
        public int? CantUnidCompraPlaza { get; set; }
    }
}
