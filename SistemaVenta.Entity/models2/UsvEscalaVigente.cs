using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvEscalaVigente
    {
        public int Pkid { get; set; }
        public int IdunidadItemListaPrecios { get; set; }
        public int Desde { get; set; }
        public int Hasta { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioIncImpto { get; set; }
        public decimal MargenNegociacionA { get; set; }
        public decimal MargenNegociacionB { get; set; }
        public decimal UtilidadMonto { get; set; }
        public decimal UtilidadPorcentual { get; set; }
        public decimal ComisionA { get; set; }
        public decimal MargenNegociacionPorcentualA { get; set; }
        public decimal MargenNegociacionPorcentualB { get; set; }
        public decimal IncrementoPorcentual { get; set; }
        public decimal MargenNegociacionPorcentualC { get; set; }
        public decimal MargenNegociacionPorcentualD { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool TieneFechaVencimiento { get; set; }
        public bool Preferencial { get; set; }
        public bool PagoEfectivo { get; set; }
        public decimal ComisionB { get; set; }
        public string EscalaVigenteId { get; set; } = null!;
        public bool EsVigente { get; set; }
        public bool Modificado { get; set; }
        public int? IdmonedaCosto { get; set; }
        public bool? MonedaCostoEsBase { get; set; }
        public decimal? CostoIgv { get; set; }
        public bool? ProductoEsInafecto { get; set; }
        public decimal CostoIncImpto { get; set; }
        public decimal MontoEscalaPreferencial { get; set; }
    }
}
