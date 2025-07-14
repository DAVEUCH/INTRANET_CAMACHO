using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranRptComprobanteVenta2
    {
        public int ComprobanteId { get; set; }
        public int TipoCpId { get; set; }
        public string TipoCpCodigo { get; set; } = null!;
        public int ClienteId { get; set; }
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public string? ClienteDi { get; set; }
        public string? ClienteDireccionPrincipal { get; set; }
        public int SucursalId { get; set; }
        public string SucursalCodigo { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public DateTime ComprobanteHora { get; set; }
        public string ComprobanteNumero { get; set; } = null!;
        public int VendedorId { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string? VendedorDi { get; set; }
        public string FuerzaVentasCodigo { get; set; } = null!;
        public string GrupoVentasCodigo { get; set; } = null!;
        public string ZonaVentaCodigo { get; set; } = null!;
        public string ZonaRepartoCodigo { get; set; } = null!;
        public bool ComprobantePrecioImpto { get; set; }
        public decimal ComprobanteValorAfecto { get; set; }
        public decimal ComprobanteValorInafecto { get; set; }
        public decimal ComprobanteValorVenta { get; set; }
        public decimal ComprobanteSubTotal { get; set; }
        public decimal ComprobanteValorDescuento { get; set; }
        public decimal ComprobanteTotal { get; set; }
        public string? VehiculoCodigo { get; set; }
        public string? VehiculoNombre { get; set; }
        public decimal? VehiculoCapacidadPeso { get; set; }
        public decimal? VehiculoCapacidadVolumen { get; set; }
        public string? VehiculoModelo { get; set; }
        public string? VehiculoMarca { get; set; }
        public string? VehiculoPlaca { get; set; }
        public string? VehiculoPlaca2 { get; set; }
        public string? VehiculoCertificadoInscripcion { get; set; }
        public string? TransportistaCodigo { get; set; }
        public string? TransportistaNombre { get; set; }
        public string? TransportistaDi { get; set; }
        public string? ChoferCodigo { get; set; }
        public string? ChoferNombre { get; set; }
        public string? ChoferDi { get; set; }
        public int ItemId { get; set; }
        public int ItemProductoId { get; set; }
        public string ItemProductoCodigo { get; set; } = null!;
        public string ItemProductoDescripcion { get; set; } = null!;
        public int ItemUnidadId { get; set; }
        public string ItemUnidadAbreviacion { get; set; } = null!;
        public int ItemUnidadFactor { get; set; }
        public string ItemUnidadBase { get; set; } = null!;
        public decimal ItemCantidad { get; set; }
        public int ItemCantidadBase { get; set; }
        public decimal ItemPorcentajeImpto { get; set; }
        public bool ItemInafecto { get; set; }
        public bool ItemBonificacion { get; set; }
        public decimal ItemValorUnitario { get; set; }
        public decimal ItemValorAfecto { get; set; }
        public decimal ItemValorVenta { get; set; }
        public decimal ItemSubTotal { get; set; }
        public decimal ItemValorDescuento { get; set; }
        public decimal ItemValorInafecto { get; set; }
        public decimal ItemDescuentoPieCp { get; set; }
        public decimal ItemRecargoPieCp { get; set; }
        public string ComprobantePuntoPartida { get; set; } = null!;
        public int? ConsolidadoId { get; set; }
        public DateTime? ConsolidadoFecha { get; set; }
        public string? ConsolidadoNumero { get; set; }
        public string ComprobanteCodSunat { get; set; } = null!;
        public DateTime FechaVencimiento { get; set; }
        public string ModalidadCredito { get; set; } = null!;
        public string? LicenciaConducir { get; set; }
        public decimal ComprobanteMontoPercepcion { get; set; }
        public decimal ComprobantePorcentajePercepcion { get; set; }
        public string DistritoPrincipalDescripcion { get; set; } = null!;
        public string ProvinciaPrincipalDescripcion { get; set; } = null!;
        public string PuntoDeLlegada { get; set; } = null!;
        public bool ItemAplicaPercepcion { get; set; }
        public decimal? ItemPercepcion { get; set; }
        public string ComprobantePuntoLlegada { get; set; } = null!;
        public int IdtipoCp { get; set; }
        public string NumCp { get; set; } = null!;
        public decimal ComprobanteImpuesto { get; set; }
        public bool DescuentoFijo { get; set; }
        public decimal Total { get; set; }
        public string NumCpRelacionado { get; set; } = null!;
        public string ClienteDireccionPrincipal2 { get; set; } = null!;
        public int ComprobanteSunatId { get; set; }
    }
}
