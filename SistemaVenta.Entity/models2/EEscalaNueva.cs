using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EEscalaNueva
    {
        public int EscalasNuevasId { get; set; }
        public int IdunidadItemListaPrecios { get; set; }
        public int EscalasNuevasDesde { get; set; }
        public int EscalasNuevasHasta { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioIncImpto { get; set; }
        public decimal UtilidadMonto { get; set; }
        public decimal UtilidadPorcentual { get; set; }
        public decimal EscalasNuevasComisionA { get; set; }
        public decimal EscalasNuevasComisionB { get; set; }
        public decimal EscalasNuevasMargenNegociacionA { get; set; }
        public decimal EscalasNuevasMargenNegociacionB { get; set; }
        public decimal EscalasNuevasMargenNegociacionPorcentualA { get; set; }
        public decimal EscalasNuevasMargenNegociacionPorcentualB { get; set; }
        public decimal EscalasNuevasMargenNegociacionPorcentualC { get; set; }
        public decimal EscalasNuevasMargenNegociacionPorcentualD { get; set; }
        public decimal EscalasNuevasIncrementoPorcentual { get; set; }
        public DateTime EscalasNuevasFechaUltimaModificacion { get; set; }
        public DateTime EscalasNuevasFechaVencimiento { get; set; }
        public bool EscalasNuevasTieneFechaVencimiento { get; set; }
        public bool EscalasNuevasPreferencial { get; set; }
        public bool EscalasNuevasPagoEfectivo { get; set; }
        public string EscalasNuevasEscalaVigenteId { get; set; } = null!;
        public bool EsVigente { get; set; }
        public bool EscalasNuevasEscalaModificada { get; set; }
        public decimal CostoIncImpto { get; set; }
        public decimal EscalasNuevasMontoEscalaPreferencial { get; set; }
    }
}
