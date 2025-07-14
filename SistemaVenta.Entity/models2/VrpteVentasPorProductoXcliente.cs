using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteVentasPorProductoXcliente
    {
        public int SucursalId { get; set; }
        public string SucursalCodigo { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public int ClienteId { get; set; }
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public int? ProductoId { get; set; }
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public int? ClaseProductoId { get; set; }
        public string? ClaseProductoCodigo { get; set; }
        public string? ClaseProductoDescripcion { get; set; }
        public int VendedorId { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string UltimoVendedor { get; set; } = null!;
        public decimal? ValorVenta2 { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? Total2 { get; set; }
        public decimal? Total { get; set; }
        public decimal? Cantidad { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public int? FactorUnidadReferencia { get; set; }
        public string? AbreviacionUnidadReferencia { get; set; }
        public DateTime Fecha { get; set; }
        public int Idperiodo { get; set; }
        public decimal? ValorVentaDolares { get; set; }
        public decimal? TotalDolares { get; set; }
        public string? Codigo { get; set; }
        public string NumCp { get; set; } = null!;
        public string TipoCp { get; set; } = null!;
        public string CodigoTipoCp { get; set; } = null!;
        public int Pkid { get; set; }
    }
}
