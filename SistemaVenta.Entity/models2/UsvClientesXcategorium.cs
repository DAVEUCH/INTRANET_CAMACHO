using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvClientesXcategorium
    {
        public string ClienteNombre { get; set; } = null!;
        public string? ClienteRuc { get; set; }
        public string? ClienteLocalidad { get; set; }
        public string? ClienteTelefono { get; set; }
        public string? ClienteTipo { get; set; }
        public string? ClienteCategoria { get; set; }
        public string? Vendedor { get; set; }
        public string LineaCreditoActiva { get; set; } = null!;
        public decimal LineaCredito { get; set; }
        public decimal? LineaUtilizada { get; set; }
        public string EstadoSunat { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public DateTime? FechaUltimaCompra { get; set; }
    }
}
