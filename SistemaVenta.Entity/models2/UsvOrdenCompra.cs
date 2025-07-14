using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvOrdenCompra
    {
        public int Pkid { get; set; }
        public int Idsucursal { get; set; }
        public string TipoDocumento { get; set; } = null!;
        public string NumeroOc { get; set; } = null!;
        public DateTime FechaOc { get; set; }
        public DateTime? FechaEntra { get; set; }
        public DateTime? FechaFact { get; set; }
        public string Sucursal { get; set; } = null!;
        public string CodigoProducto { get; set; } = null!;
        public string? SegmentoProducto { get; set; }
        public string? Codigointerno { get; set; }
        public string? Especialidad { get; set; }
        public DateTime? FechaultimaImportacion { get; set; }
        public string DescripcionProducto { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; } = null!;
        public int? Devolucion { get; set; }
        public decimal? CostoaSolesSinigv { get; set; }
        public decimal? CostoaDolaresSinigv { get; set; }
        public string? EstadoFacturacion { get; set; }
        public string? FacturaNumero { get; set; }
        public decimal? FacturaCostoSinIgvASoles { get; set; }
        public decimal? FacturaCostoSinIgvADolares { get; set; }
        public int Stocksucursal { get; set; }
        public int? Stockempresa { get; set; }
        public decimal? AnteriorCostodeCompraADolaresSinIgv { get; set; }
        public string? Vendedor { get; set; }
        public string? Proveedor { get; set; }
        public string? CondicionComercial { get; set; }
        public string Observacion { get; set; } = null!;
    }
}
