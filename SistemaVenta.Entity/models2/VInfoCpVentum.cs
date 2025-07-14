using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpVentum
    {
        public int ComprobanteId { get; set; }
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public DateTime ComprobanteHora { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteNumCpContable { get; set; } = null!;
        public string ComprobanteObservacion { get; set; } = null!;
        public string? ComprobanteOrigenDestinoNombre { get; set; }
        public bool ComprobanteAnulado { get; set; }
        public bool ComprobanteContabilizado { get; set; }
        public bool ComprobantePreliminar { get; set; }
        public string ComprobanteDocIdentidad { get; set; } = null!;
        public bool ComprobantePreciosIncluidoImpuesto { get; set; }
        public bool ComprobanteClienteEsEstandar { get; set; }
        public string ComprobatenDireccion { get; set; } = null!;
        public string ComprobanteDireccionEntrega { get; set; } = null!;
        public string ComprobanteEstadoEntrega { get; set; } = null!;
        public string ComprobanteEstadoDevolucion { get; set; } = null!;
        public string ComprobanteEstadoEntregaDevolucion { get; set; } = null!;
        public string ComprobanteEstadoDescuento { get; set; } = null!;
        public bool ComprobanteVentaEspecial { get; set; }
        public string ComprobanteNumeroReferencia { get; set; } = null!;
        public decimal ComprobanteBaseImponibleInafecto { get; set; }
        public decimal ComprobanteBaseImponibleAfecto { get; set; }
        public decimal? ComprobanteMontoImpuesto { get; set; }
        public decimal ComprobanteValorDescuento { get; set; }
        public decimal ComprobanteTotal { get; set; }
        public string? ComprobanteTotalEnLetras { get; set; }
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string SucursalDireccion { get; set; } = null!;
        public int PeriodoId { get; set; }
        public string PeriodoDescripcion { get; set; } = null!;
        public int MonedaId { get; set; }
        public string MonedaDescripcion { get; set; } = null!;
        public string MonedaSimbolo { get; set; } = null!;
        public bool MonedaEsBase { get; set; }
        public int TipoComprobanteId { get; set; }
        public string TipoComprobanteCodigo { get; set; } = null!;
        public string TipoComprobanteAbreviacion { get; set; } = null!;
        public int ConceptoId { get; set; }
        public string ConceptoCodigo { get; set; } = null!;
        public string ConceptoDescripcion { get; set; } = null!;
        public int? OrigenDestinoId { get; set; }
        public string? OrigenDestinoNombre { get; set; }
        public string? OrigenDestinoCodigo { get; set; }
        public bool? OrigenDestinoEsEstandar { get; set; }
        public string OrigenDestinoDocumentoIdentidad { get; set; } = null!;
        public string? OrigenDestinoDireccionDescripcion { get; set; }
        public string OrigenDestinoDireccionSucursal { get; set; } = null!;
        public string? OrigenDestinoDireccionDistrito { get; set; }
        public string? OrigenDesitnoDireccionProvincia { get; set; }
        public string? OrigenDestinoDireccionDepartamento { get; set; }
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
        public DateTime CobrarPagarFechaVencimiento { get; set; }
        public decimal CobrarPagarSaldo { get; set; }
        public decimal CobrarPagarTotal { get; set; }
        public bool CobrarPagarCredito { get; set; }
        public DateTime CobrarPagarFechaProgramacionPago { get; set; }
        public string CreditoCodigo { get; set; } = null!;
        public string CreditoDescripcion { get; set; } = null!;
        public int CreditoDias { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string VendedorGrupoVentaCodigo { get; set; } = null!;
        public string VendedorGrupoVentaNombre { get; set; } = null!;
        public string VendedorFuerzaVentaCodigo { get; set; } = null!;
        public string VendedorFuerzaVentaNombre { get; set; } = null!;
        public string NumCpRelacionadosNivel1 { get; set; } = null!;
        public string TransportistaNombre { get; set; } = null!;
        public string TransportistaRuc { get; set; } = null!;
        public string ChoferNombre { get; set; } = null!;
        public string ChoferLicenciaConducir { get; set; } = null!;
        public string VehiculoNombre { get; set; } = null!;
        public string VehiculoModelo { get; set; } = null!;
        public string VehiculoMarca { get; set; } = null!;
        public string VehiculoPlaca { get; set; } = null!;
        public string VehiculoPlaca2 { get; set; } = null!;
        public decimal VehiculoCapacidadPeso { get; set; }
        public decimal VehiculoCapacidadVolumen { get; set; }
        public string? ItemDescripcion { get; set; }
        public decimal ItemCantidad { get; set; }
        public decimal? ItemValorUnitario { get; set; }
        public decimal ItemBaseImponibleInafecto { get; set; }
        public decimal ItemTotal { get; set; }
        public decimal ItemTotalIncluidoImpuesto { get; set; }
        public int? ItemCantidadUnidadBase { get; set; }
        public string? ItemUnidadAbreviacion { get; set; }
        public bool? ItemUnidadEsBase { get; set; }
        public string? ItemProductoCodigo { get; set; }
        public string? ItemProductoCodigoAfinidad { get; set; }
        public string? ItemProductoCodigoFabrica { get; set; }
        public string? ItemProductoDescripcion { get; set; }
        public string? ItemProductoClasificacionCodigo { get; set; }
        public string? ItemProductoClasificacionDescripcion { get; set; }
        public string? ItemProductoMarcaDescripcion { get; set; }
        public decimal ItemPorcentajeImpuesto { get; set; }
        public decimal ItemBalanceEntrega { get; set; }
        public decimal ItemPrecioLista { get; set; }
        public bool ItemEsBonificacion { get; set; }
        public bool ItemEsInafecto { get; set; }
        public bool ItemAplicaDescuentoConVale { get; set; }
        public decimal ItemBalanceDevolucion { get; set; }
        public decimal ItemBalanceEntregaDevolucion { get; set; }
        public decimal ItemBalanceDescuento { get; set; }
        public bool ItemEsEscalaPreferencial { get; set; }
        public decimal ItemDescuentoAplicado { get; set; }
        public bool ItemDescuentoFijo { get; set; }
        public string? ItemNumeroLote { get; set; }
        public string NumCp { get; set; } = null!;
        public int IdtipoCp { get; set; }
        public int? ItemProductoId { get; set; }
        public int ResponsableId { get; set; }
        public string ComprobanteConsolidadoDma { get; set; } = null!;
        public string TipoCliente { get; set; } = null!;
        public int Pkid { get; set; }
        public string ZonaCodigo { get; set; } = null!;
        public string ZonaDescripcion { get; set; } = null!;
        public decimal? ComprobanteMontoPercepcion { get; set; }
        public decimal? ComprobanteMontoDetraccion { get; set; }
        public decimal? ComprobanteTotalNeto { get; set; }
        public decimal? ComprobantePorcentajePercepcion { get; set; }
        public bool OrigenDestinoAgentePercepcion { get; set; }
        public bool? ComprobanteCredito { get; set; }
        public decimal? ItemProductoPeso { get; set; }
        public decimal ItemValorDescuento { get; set; }
        public decimal ItemProductoDscto { get; set; }
        public decimal ItemProductoRecargo { get; set; }
    }
}
