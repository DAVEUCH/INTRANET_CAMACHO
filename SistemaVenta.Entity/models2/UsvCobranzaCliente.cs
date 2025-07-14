using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCobranzaCliente
    {
        public string TipoCobranza { get; set; } = null!;
        public string NumeroCobranza { get; set; } = null!;
        public DateTime FechaCobranza { get; set; }
        public string? Responsable { get; set; }
        public string Caja { get; set; } = null!;
        public string? TipoDoc { get; set; }
        public string? NumeroDoc { get; set; }
        public DateTime? FechaDoc { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public int Morosidad0hasta10 { get; set; }
        public int Morosidad11hasta20 { get; set; }
        public int Morosidad21hasta30 { get; set; }
        public int Morosidad31aMas { get; set; }
        public string? NombreCliente { get; set; }
        public string? RucoDni { get; set; }
        public string? Vendedor { get; set; }
        public string? MoneDoc { get; set; }
        public decimal? TotalDoc { get; set; }
        public decimal? ImpCobradoSoles { get; set; }
        public decimal? ImpCobradoDolares { get; set; }
        public string Observacion { get; set; } = null!;
    }
}
