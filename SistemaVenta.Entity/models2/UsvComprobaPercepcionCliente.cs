using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvComprobaPercepcionCliente
    {
        public string? SerieCompPercep { get; set; }
        public string? NroCompPercep { get; set; }
        public string? RucCliente { get; set; }
        public string? Cliente { get; set; }
        public string ApellidoPat { get; set; } = null!;
        public string ApellidoMat { get; set; } = null!;
        public string? Nombres { get; set; }
        public decimal TotalPercepcion { get; set; }
        public DateTime FechaPercepcion { get; set; }
        public string? SerieFactura { get; set; }
        public string? NumeroFactura { get; set; }
        public DateTime? FechaFactura { get; set; }
        public decimal? TotalFactura { get; set; }
        public decimal? VtaAplicaPercepcion { get; set; }
        public decimal? ProcentajePercepcion { get; set; }
        public string Anulado { get; set; } = null!;
    }
}
