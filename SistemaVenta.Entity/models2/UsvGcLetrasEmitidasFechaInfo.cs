using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvGcLetrasEmitidasFechaInfo
    {
        public string Numcp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? Cliente { get; set; }
        public string? Departamento { get; set; }
        public string? Provincia { get; set; }
        public string? Distrito { get; set; }
        public string? TipoDoc { get; set; }
        public decimal Total { get; set; }
        public decimal? Saldo { get; set; }
    }
}
