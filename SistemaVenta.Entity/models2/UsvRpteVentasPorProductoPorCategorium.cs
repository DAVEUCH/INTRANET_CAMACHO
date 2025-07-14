using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvRpteVentasPorProductoPorCategorium
    {
        public string SucursalNombre { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public int CategoriaId { get; set; }
        public string CategoriaCodigo { get; set; } = null!;
        public string CategoriaDescripcion { get; set; } = null!;
        public int TipoClienteId { get; set; }
        public string TipoClienteCodigo { get; set; } = null!;
        public string TipoClienteDescripcion { get; set; } = null!;
        public int ClienteId { get; set; }
        public string? ClienteRuc { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public string? Departamento { get; set; }
        public DateTime FechaEmision { get; set; }
        public string TipoCp { get; set; } = null!;
        public string CodigoTipoCp { get; set; } = null!;
        public string NroComprobante { get; set; } = null!;
        public string Scomprobante { get; set; } = null!;
        public int? ProductoId { get; set; }
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public decimal? ValorVentaSoles { get; set; }
        public decimal? TotalSoles { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? CantidadUnidadBase { get; set; }
        public int? FactorUnidadReferencia { get; set; }
        public decimal? ValorVentaDolares { get; set; }
        public decimal? TotalDolares { get; set; }
        public decimal NcvalorVentaSoles { get; set; }
        public decimal NcvalorVentaDolares { get; set; }
        public int? Idproducto { get; set; }
        public int? IdNotaCredito { get; set; }
        public string? NroNotaCredito { get; set; }
        public int Pkid { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
    }
}
