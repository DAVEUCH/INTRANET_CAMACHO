using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VHelpVictor
    {
        public int Idcliente { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Activo { get; set; }
        public string Direccion { get; set; } = null!;
        public string Distrito { get; set; } = null!;
        public string? DocIdentidad { get; set; }
        public string Giro { get; set; } = null!;
        public string Categoria { get; set; } = null!;
        public string ZonaCodigoPreventa { get; set; } = null!;
        public string ZonaDescripcionPreventa { get; set; } = null!;
        public string ZonaCodigoReparto { get; set; } = null!;
        public string ZonaDescripcionReparto { get; set; } = null!;
        public string CodigoVendedor { get; set; } = null!;
        public string NombreVendedor { get; set; } = null!;
        public int Idvendedor { get; set; }
        public string DiaDeSemana { get; set; } = null!;
        public string? Urbanizacion { get; set; }
        public bool DireccionPrincipal { get; set; }
        public DateTime FechaAniversario { get; set; }
        public DateTime FechaCumpleaños { get; set; }
        public string? Motivo { get; set; }
        public string Memo { get; set; } = null!;
        public string? NombreContacto { get; set; }
        public string? Caracteristica3 { get; set; }
        public string? Caracteristica4 { get; set; }
        public string Campo1 { get; set; } = null!;
        public string Campo2 { get; set; } = null!;
        public string Campo3 { get; set; } = null!;
        public string Campo4 { get; set; } = null!;
        public string? NumeroTelefono { get; set; }
    }
}
