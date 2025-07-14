using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionCpCabecera
    {
        public int ComprobanteId { get; set; }
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public DateTime ComprobanteHora { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteNumCpContable { get; set; } = null!;
        public string ComprobanteObservacion { get; set; } = null!;
        public string ComprobantePersonaNombre { get; set; } = null!;
        public decimal ComprobanteTotal { get; set; }
        public bool ComprobanteAnulado { get; set; }
        public bool ComprobanteContabilizado { get; set; }
        public bool ComprobantePreliminar { get; set; }
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
        public string ComprobanteTipoPersona { get; set; } = null!;
        public int PersonaId { get; set; }
        public string PersonaNombre { get; set; } = null!;
        public string PersonaCodigo { get; set; } = null!;
        public bool PersonaEsEstandar { get; set; }
        public string PersonaDocumentoIdentidad { get; set; } = null!;
        public string PersonaDireccionDescripcion { get; set; } = null!;
        public string PersonaDireccionSucursal { get; set; } = null!;
        public string PersonaDireccionDistrito { get; set; } = null!;
        public string PersonaDireccionProvincia { get; set; } = null!;
        public string PersonaDireccionDepartamento { get; set; } = null!;
        public int MotivoAnulacionId { get; set; }
        public string MotivoAnulacionCodigo { get; set; } = null!;
        public string MotivoAnulacionDescripcion { get; set; } = null!;
        public bool MotivoAnulacionOficina { get; set; }
        public int AlmacenId { get; set; }
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
        public int CobrarPagarId { get; set; }
        public DateTime CobrarPagarFechaVencimiento { get; set; }
        public decimal CobrarPagarSaldo { get; set; }
        public decimal CobrarPagarTotal { get; set; }
        public bool CobrarPagarCredito { get; set; }
        public DateTime CobrarPagarFechaProgramacionPago { get; set; }
        public string CobrarPagarTipo { get; set; } = null!;
        public int CreditoId { get; set; }
        public string CreditoCodigo { get; set; } = null!;
        public string CreditoDescripcion { get; set; } = null!;
        public int CreditoDias { get; set; }
        public int VoucherContableId { get; set; }
        public bool ComprobanteEsTercero { get; set; }
        public int ComprobanteIdresponsable { get; set; }
        public decimal ComprobanteValorAfecto { get; set; }
        public decimal ComprobanteValorInafecto { get; set; }
        public decimal ComprobanteValorVenta { get; set; }
        public decimal ComprobanteSubTotal { get; set; }
        public decimal ComprobanteValorDescuento { get; set; }
        public bool ComprobantePreciosIncImpto { get; set; }
    }
}
