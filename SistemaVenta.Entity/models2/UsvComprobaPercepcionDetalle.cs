using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvComprobaPercepcionDetalle
    {
        public int Pkid { get; set; }
        public string? SerieCompPercep { get; set; }
        public string? NroCompPercep { get; set; }
        public string? FechaPercepAñoMesDia { get; set; }
        public string? RucCliente { get; set; }
        public string? Cliente { get; set; }
        public decimal TotalPercepcion { get; set; }
        public DateTime FechaPercepcion { get; set; }
        public int Pkidfact { get; set; }
        public string? SerieFactura { get; set; }
        public string? NumeroFactura { get; set; }
        public string? FechaFacturaAñoMesDia { get; set; }
        public decimal TotalFactura { get; set; }
        public DateTime FechaUltimoPago { get; set; }
        public int IdmodalidadCredito { get; set; }
        public string? TipoDocCodeFact { get; set; }
        public string? MonedaCodeFact { get; set; }
        public decimal? MontoPercepcion { get; set; }
    }
}
