using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvPrestamosBancosyLetra
    {
        public int Pkid { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public string NumeroPrestamo { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public string SimboloMoneda { get; set; } = null!;
        public decimal Total { get; set; }
        public DateTime FechaLetra { get; set; }
        public string NumeroLetra { get; set; } = null!;
        public int Dias { get; set; }
        public DateTime? FechaVence { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal? Saldo { get; set; }
    }
}
