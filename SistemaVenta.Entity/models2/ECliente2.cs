using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECliente2
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
        public int? ClienteIdcliente { get; set; }
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
        public bool ExceptuadoDePercepcion { get; set; }
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
        public int? DireccionesId { get; set; }
        public int? DireccionesIddistrito { get; set; }
        public int? DireccionesIdprovincia { get; set; }
        public int? DireccionesIddepartamento { get; set; }
        public int? Idpersona { get; set; }
        public string? DireccionesDescripcion { get; set; }
        public bool? DireccionesDireccionPrincipal { get; set; }
        public string? DireccionesSucursal { get; set; }
        public int DireccionesDireccionIdzonaReparto { get; set; }
        public int DireccionIdzonaReparto { get; set; }
        public string? Sucursal { get; set; }
        public bool? DireccionPrincipal { get; set; }
        public int? Iddepartamento { get; set; }
        public int? Idprovincia { get; set; }
        public int? Iddistrito { get; set; }
        public string? Descripcion { get; set; }
        public decimal DireccionLongitud { get; set; }
        public decimal DireccionLatitud { get; set; }
    }
}
