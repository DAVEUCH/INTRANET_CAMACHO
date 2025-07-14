using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VImpresionCpVentaSinProdCombos09
    {
        public int Pkid { get; set; }
        public string NumeroCp { get; set; } = null!;
        public string? NombrePersona { get; set; }
        public string? DocumentoPersona { get; set; }
        public string? DireccionPrincipalPersona { get; set; }
        public string? DireccionCp { get; set; }
        public string? DireccionEntrega { get; set; }
        public DateTime Fecha { get; set; }
        public string Modalidad { get; set; } = null!;
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string? DocumentoAnterior { get; set; }
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public string? ProductoDescripcionResumida { get; set; }
        public decimal ProductoCantidad { get; set; }
        public string UnidadMedida { get; set; } = null!;
        public decimal? PrecioLista { get; set; }
        public decimal? ImporteBruto { get; set; }
        public decimal DescuentoAplicado { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? TotalNeto { get; set; }
        public decimal ValorAfecto { get; set; }
        public decimal ValorInafecto { get; set; }
        public decimal? SumaBruto { get; set; }
        public decimal? SumaDescuento { get; set; }
        public decimal? DescuentoxMonto { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? ValorIgv { get; set; }
        public decimal? NetoPagar { get; set; }
        public string? TotalLetras { get; set; }
        public string SimboloMoneda { get; set; } = null!;
        public int IdMoneda { get; set; }
        public string? MonedaDescripcion { get; set; }
        public bool EsItemAgrupacion { get; set; }
    }
}
