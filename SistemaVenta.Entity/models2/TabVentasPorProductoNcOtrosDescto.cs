using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabVentasPorProductoNcOtrosDescto
    {
        public int Idventa { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Idperiodo { get; set; }
        public string? Mes { get; set; }
        public string? Año { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public string? TipoCp { get; set; }
        public string? CodigoTipoCp { get; set; }
        public string? ConceptoOperacion { get; set; }
        public int? MarcaId { get; set; }
        public string? MarcaCodigo { get; set; }
        public string? MarcaDescripcion { get; set; }
        public string? CategoriaDescripcion { get; set; }
        public int? TipoClienteId { get; set; }
        public string? TipoClienteCodigo { get; set; }
        public string? TipoClienteDescripcion { get; set; }
        public int? ClienteId { get; set; }
        public string? ClienteCodigo { get; set; }
        public string? ClienteNombre { get; set; }
        public int? ProductoId { get; set; }
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public int? ClaseProductoId { get; set; }
        public string? ClaseProductoCodigo { get; set; }
        public string? ClaseProductoDescripcion { get; set; }
        public string? AbreviacionUnidadReferencia { get; set; }
        public int? FactorUnidadReferencia { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? ValorUnitario { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public decimal? ValorVentaSoles { get; set; }
        public decimal? TotalSoles { get; set; }
        public decimal? ValorVentaDolares { get; set; }
        public decimal? TotalDolares { get; set; }
    }
}
