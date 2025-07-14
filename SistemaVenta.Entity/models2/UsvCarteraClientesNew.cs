using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCarteraClientesNew
    {
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Localidad { get; set; }
        public string? Telefono { get; set; }
        public decimal? LineaCredito { get; set; }
        public decimal? LineaUtilizada { get; set; }
        public decimal? LineaDisponible { get; set; }
        public string? Categoria { get; set; }
        public string? TipoCliente { get; set; }
        public DateTime? UltimaFechaVenta { get; set; }
        public string CondicionCliente { get; set; } = null!;
        public string EstadoCliente { get; set; } = null!;
        public string? Vendedor { get; set; }
        public string? VendeAsignado { get; set; }
        public string? Ruccliente { get; set; }
        public DateTime? FechaCrea { get; set; }
        public string Observacion { get; set; } = null!;
        public int? Idcliente { get; set; }
    }
}
