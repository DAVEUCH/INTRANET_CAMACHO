using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvPrestamosDeCapital
    {
        public int Pkid { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public string NumeroPrestamo { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public string SimboloMoneda { get; set; } = null!;
        public decimal Total { get; set; }
    }
}
