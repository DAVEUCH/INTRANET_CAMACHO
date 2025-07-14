using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvLetrasPorCobrarPorEdadesVcto
    {
        public int? EdadMesXvencer { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string NumCp { get; set; } = null!;
        public string? NumeroUnicoBanco { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
        public string Localidad { get; set; } = null!;
        public string? Telefono { get; set; }
        public string Moneda { get; set; } = null!;
        public string? CuentaDescripcion { get; set; }
        public string? Estado { get; set; }
    }
}
