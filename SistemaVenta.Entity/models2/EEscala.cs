using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EEscala
    {
        public int EscalasId { get; set; }
        public int IdunidadItemListaPrecios { get; set; }
        public int EscalasDesde { get; set; }
        public int EscalasHasta { get; set; }
        public decimal EscalasPrecio { get; set; }
        public decimal EscalasPrecioIncImpto { get; set; }
        public decimal EscalasMargenNegociacionA { get; set; }
        public decimal EscalasMargenNegociacionB { get; set; }
        public decimal EscalasUtilidadMonto { get; set; }
        public decimal EscalasUtilidadPorcentual { get; set; }
        public decimal EscalasMargenNegociacionPorcentualA { get; set; }
        public decimal EscalasMargenNegociacionPorcentualB { get; set; }
        public decimal EscalasIncrementoPorcentual { get; set; }
        public decimal EscalasMargenNegociacionPorcentualC { get; set; }
        public decimal EscalasMargenNegociacionPorcentualD { get; set; }
        public DateTime EscalasFechaUltimaModificacion { get; set; }
        public DateTime EscalasFechaVencimiento { get; set; }
        public bool EscalasTieneFechaVencimiento { get; set; }
        public bool EscalasPreferencial { get; set; }
        public bool EscalasPagoEfectivo { get; set; }
        public decimal EscalasComisionA { get; set; }
        public decimal EscalasComisionB { get; set; }
        public string EscalasEscalaVigenteId { get; set; } = null!;
        public bool EscalasEsVigente { get; set; }
        public bool EscalasEscalaModificada { get; set; }
        public decimal EscalasCostoIncImpto { get; set; }
        public decimal EscalasMontoEscalaPreferencial { get; set; }
    }
}
