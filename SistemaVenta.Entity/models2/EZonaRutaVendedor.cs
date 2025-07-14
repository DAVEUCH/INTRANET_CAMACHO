using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EZonaRutaVendedor
    {
        public int Pkid { get; set; }
        public int IdrutaVendedor { get; set; }
        public int ZonasRutaIdzona { get; set; }
        public int? ZonasRutaNumeroSemanas { get; set; }
        public DateTime? ZonasRutaFechaInicio { get; set; }
    }
}
