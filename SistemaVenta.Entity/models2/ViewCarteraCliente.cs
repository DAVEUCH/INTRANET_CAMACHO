using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ViewCarteraCliente
    {
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Localidad { get; set; }
        public string? Telefono { get; set; }
        public decimal? LineaDisponible { get; set; }
        public string? Categoria { get; set; }
        public string? TipoCliente { get; set; }
        public string? Moroso { get; set; }
        public string? ModalidadCredito { get; set; }
        public string? MedioDePago { get; set; }
        public bool? Corporativo { get; set; }
        public string? ClienteCorporaivo { get; set; }
        public DateTime? UltimaFechaVenta { get; set; }
        public string CondicionCliente { get; set; } = null!;
        public string EstadoCliente { get; set; } = null!;
        public string? Vendedor { get; set; }
        public int? Idcliente { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCrea { get; set; }
    }
}
