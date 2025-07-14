using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VLetrasGeneralNess
    {
        public DateTime Fecha { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string NumCp { get; set; } = null!;
        public string NumeroUnicoBanco { get; set; } = null!;
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public decimal Total { get; set; }
        public decimal? Saldo { get; set; }
        public string? Localidad { get; set; }
        public string? Telefono { get; set; }
        public string? Moneda { get; set; }
        public string? CuentaDescripcion { get; set; }
        public string? Estado { get; set; }
        public int? Idestado { get; set; }
    }
}
