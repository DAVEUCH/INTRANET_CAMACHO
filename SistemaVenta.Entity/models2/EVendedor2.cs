using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EVendedor2
    {
        public int Id { get; set; }
        public int IddireccionPrincipal { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Descriptivo { get; set; }
        public bool Activo { get; set; }
        public int IdtipoTercero { get; set; }
        public int IdtipoDocIdentidad { get; set; }
        public string Email { get; set; } = null!;
        public string Web { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string DocIdentidad { get; set; } = null!;
        public int EmpleadoId { get; set; }
        public int EmpleadoIdcargoEmpleado { get; set; }
        public DateTime EmpleadoFechaIngreso { get; set; }
        public string EmpleadoLicenciaConducir { get; set; } = null!;
        public int EmpleadoVendedorIdgrupoVentas { get; set; }
        public bool EmpleadoVendedorFueraDeRuta { get; set; }
        public decimal EmpleadoVendedorComisionVenta { get; set; }
        public decimal EmpleadoVendedorComisionCobranza { get; set; }
        public int EmpleadoVendedorDiasDeGracia { get; set; }
        public DateTime FechaAniversario { get; set; }
        public DateTime FechaCumpleaños { get; set; }
        public string ApellidoPaterno { get; set; } = null!;
        public string ApellidoMaterno { get; set; } = null!;
        public string PrimerNombre { get; set; } = null!;
        public string SegundoNombre { get; set; } = null!;
        public bool AgenteRetencion { get; set; }
        public bool AgentePercepcion { get; set; }
        public bool Extranjero { get; set; }
        public string CuentaBancaria { get; set; } = null!;
    }
}
