using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EProveedor2
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Web { get; set; } = null!;
        public int ProveedorIdmoneda { get; set; }
        public int ProveedorIdmodalidadCredito { get; set; }
        public string ProveedorIdmonedaListaPrecio { get; set; } = null!;
        public decimal ProveedorLineaCredito { get; set; }
        public decimal ProveedorBalanceSoles { get; set; }
        public decimal ProveedorBalanceDolares { get; set; }
        public int ProveedorDiasCredito { get; set; }
        public bool ProveedorRestrictivo { get; set; }
        public bool ProveedorEntregaDistribuida { get; set; }
        public bool ProveedorEntregaCentralizada { get; set; }
        public bool ProveedorProveedorGiro { get; set; }
        public bool ProveedorCreditoContado { get; set; }
        public int ProveedorIdtipoMedioDePago { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime FechaAniversario { get; set; }
        public bool Descriptivo { get; set; }
        public string Codigo { get; set; } = null!;
        public string SegundoNombre { get; set; } = null!;
        public bool AgenteRetencion { get; set; }
        public bool Activo { get; set; }
        public bool Extranjero { get; set; }
        public string ApellidoMaterno { get; set; } = null!;
        public DateTime FechaCumpleaños { get; set; }
        public int IdtipoDocIdentidad { get; set; }
        public string Observacion { get; set; } = null!;
        public string? DocIdentidad { get; set; }
        public string CuentaBancaria { get; set; } = null!;
        public string ApellidoPaterno { get; set; } = null!;
        public int IdtipoTercero { get; set; }
        public int IddireccionPrincipal { get; set; }
        public bool AgentePercepcion { get; set; }
        public string PrimerNombre { get; set; } = null!;
        public bool ExceptuadoDePercepcion { get; set; }
        public int ProveedorRelacionada { get; set; }
    }
}
