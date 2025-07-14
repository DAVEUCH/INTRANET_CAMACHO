using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteCuentaCorrienteCajaSaldoInicialDisponible
    {
        public int Pkid { get; set; }
        public DateTime ComprobanteFecha { get; set; }
        public int CajaId { get; set; }
        public decimal? CargoSoles { get; set; }
        public decimal? AbonoSoles { get; set; }
        public decimal? CargoDolares { get; set; }
        public decimal? AbonoDolares { get; set; }
    }
}
