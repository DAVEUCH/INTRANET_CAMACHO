using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VPruebaCliente
    {
        public int Id { get; set; }
        public int TipoDePersona { get; set; }
        public int TipoDocIdentidad { get; set; }
        public string Email { get; set; } = null!;
        public string Web { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string? DocIdentidad { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string APaterno { get; set; } = null!;
        public string AMaterno { get; set; } = null!;
        public string Nombre1 { get; set; } = null!;
        public string Nombre2 { get; set; } = null!;
        public bool Descriptivo { get; set; }
        public bool Activo { get; set; }
        public bool AgenteRetencion { get; set; }
        public bool AgentePercepcion { get; set; }
        public bool Extranjero { get; set; }
        public string CuentaBancaria { get; set; } = null!;
        public DateTime FechaAniversario { get; set; }
        public DateTime FechaCumpleaños { get; set; }
        public int IddireccionPrincipal { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
