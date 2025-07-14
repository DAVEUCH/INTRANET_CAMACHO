using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECliente
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
        public string? DocIdentidad { get; set; }
        public int ClienteIdcliente { get; set; }
        public int ClienteIdcategoriaCliente { get; set; }
        public int ClienteIdmoneda { get; set; }
        public int ClienteIdmodalidadCredito { get; set; }
        public decimal ClienteLineaCredito { get; set; }
        public decimal ClienteBalanceSoles { get; set; }
        public decimal ClienteBalanceDolares { get; set; }
        public bool ClienteMejorPrecio { get; set; }
        public int ClienteDiasCredito { get; set; }
        public int ClienteIdtipoMedioDePago { get; set; }
        public bool ClienteCreditoContado { get; set; }
        public bool ClienteInhabilitadoBonificacion { get; set; }
        public bool ClienteInhabilitadoDescuento { get; set; }
        public int ClienteIdtipoCliente { get; set; }
        public bool ClienteLineaCreditoPorFuerzaVentas { get; set; }
        public int ClienteMaximoCuentasPorCobrarVencidas { get; set; }
        public string ClienteCampo1 { get; set; } = null!;
        public string ClienteCampo2 { get; set; } = null!;
        public string ClienteCampo3 { get; set; } = null!;
        public string ClienteCampo4 { get; set; } = null!;
        public int ClienteIdcaracteristica1 { get; set; }
        public int ClienteIdcaracteristica2 { get; set; }
        public int ClienteIdcaracteristica3 { get; set; }
        public int ClienteIdcaracteristica4 { get; set; }
        public bool ClienteCorporativo { get; set; }
        public int ClienteIdclienteCorporativo { get; set; }
        public bool ClienteLineaCreditoCorporativa { get; set; }
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
        public bool ClienteLineaCreditoActiva { get; set; }
        public bool ExceptuadoDePercepcion { get; set; }
    }
}
