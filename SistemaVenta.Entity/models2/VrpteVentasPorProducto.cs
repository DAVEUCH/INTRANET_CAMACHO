using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteVentasPorProducto
    {
        public int SucursalId { get; set; }
        public string SucursalCodigo { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public int CategoriaId { get; set; }
        public string CategoriaCodigo { get; set; } = null!;
        public string CategoriaDescripcion { get; set; } = null!;
        public int ZonaId { get; set; }
        public string ZonaCodigo { get; set; } = null!;
        public string ZonaDescripcion { get; set; } = null!;
        public int FuerzaVentasId { get; set; }
        public string FuerzaVentasCodigo { get; set; } = null!;
        public string FuerzaVentasNombre { get; set; } = null!;
        public int? GrupoVentasId { get; set; }
        public string? GrupoVentasCodigo { get; set; }
        public string? GrupoVentasNombre { get; set; }
        public int TipoClienteId { get; set; }
        public string TipoClienteCodigo { get; set; } = null!;
        public string TipoClienteDescripcion { get; set; } = null!;
        public int ClienteId { get; set; }
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public int? ProductoId { get; set; }
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public int? MarcaId { get; set; }
        public string? MarcaCodigo { get; set; }
        public string? MarcaDescripcion { get; set; }
        public int ProveedorId { get; set; }
        public string ProveedorCodigo { get; set; } = null!;
        public string ProveedorNombre { get; set; } = null!;
        public int? ClaseProductoId { get; set; }
        public string? ClaseProductoCodigo { get; set; }
        public string? ClaseProductoDescripcion { get; set; }
        public int VendedorId { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public decimal TipoCambio { get; set; }
        public decimal? ValorVenta2 { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? Total2 { get; set; }
        public decimal? Total { get; set; }
        public decimal? ValorVentaDolares { get; set; }
        public decimal? TotalDolares { get; set; }
        public decimal? Cantidad { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public int? FactorUnidadReferencia { get; set; }
        public string? AbreviacionUnidadReferencia { get; set; }
        public DateTime Fecha { get; set; }
        public int Idperiodo { get; set; }
        public string? Codigo { get; set; }
        public string NumCp { get; set; } = null!;
        public string TipoCp { get; set; } = null!;
        public string CodigoTipoCp { get; set; } = null!;
        public string CodigoSerie { get; set; } = null!;
        public string DescripModalidadCredito { get; set; } = null!;
        public int Pkid { get; set; }
        public int EsCompraCp { get; set; }
    }
}
