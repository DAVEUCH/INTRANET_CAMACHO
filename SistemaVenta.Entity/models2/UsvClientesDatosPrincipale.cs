using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvClientesDatosPrincipale
    {
        public int Idersona { get; set; }
        public string? DocIdentidad { get; set; }
        public string NombreCliente { get; set; } = null!;
        public string? DireccionCliente { get; set; }
        public string? LocalidadCliente { get; set; }
        public string? Telefono { get; set; }
        public string? CategoriaCliente { get; set; }
        public string? TipoCliente { get; set; }
        public decimal? LineaCredito { get; set; }
        public decimal? LineaUtilizada { get; set; }
        public decimal? LineaDisponible { get; set; }
    }
}
