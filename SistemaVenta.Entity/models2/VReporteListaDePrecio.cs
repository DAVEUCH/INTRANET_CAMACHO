using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VReporteListaDePrecio
    {
        public string Simbolo { get; set; } = null!;
        public string TipoEntidad { get; set; } = null!;
        public string Entidad { get; set; } = null!;
        public string CostoReferencia { get; set; } = null!;
        public decimal TipoCambioCompra { get; set; }
        public decimal TipoCambioVenta { get; set; }
        public bool TieneDescuentoPorVale { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Desactivado { get; set; }
        public string Expr1 { get; set; } = null!;
        public int Factor { get; set; }
        public int Desde { get; set; }
        public int Hasta { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioIncImpto { get; set; }
        public decimal? CostoIgv { get; set; }
        public decimal CostoIncImpto { get; set; }
        public decimal MargenNegociacionPorcentualA { get; set; }
        public decimal MargenNegociacionPorcentualB { get; set; }
        public decimal MargenNegociacionPorcentualC { get; set; }
        public decimal MargenNegociacionPorcentualD { get; set; }
        public decimal PorcentajeImpuesto { get; set; }
        public string Abreviacion { get; set; } = null!;
    }
}
