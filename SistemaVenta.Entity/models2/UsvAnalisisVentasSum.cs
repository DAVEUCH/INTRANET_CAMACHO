using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvAnalisisVentasSum
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string? Periodo { get; set; }
        public decimal? Pdvalq { get; set; }
        public decimal? PdvpmTero { get; set; }
        public decimal? Pdv06 { get; set; }
        public decimal? Pdv02 { get; set; }
        public decimal? Pdv05 { get; set; }
        public decimal? Pdv07 { get; set; }
        public decimal? Pdv09Corporativo { get; set; }
        public decimal? Pdv09 { get; set; }
        public decimal? PdvvpmGci { get; set; }
        public decimal? PdvvpmIrc { get; set; }
        public decimal? VtasInteres { get; set; }
        public decimal? VtasObsequios { get; set; }
        public decimal? VtasAnticipos { get; set; }
        public decimal? VtasTotal { get; set; }
    }
}
