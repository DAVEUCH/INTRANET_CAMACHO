using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteCobranzasPagosEfectuadosComisione
    {
        public string TipoPersona { get; set; } = null!;
        public string DocumentoCobrarPagarPersonaCodigo { get; set; } = null!;
        public string DocumentoCobrarPagarPersonaNombre { get; set; } = null!;
        public DateTime? ComprobanteFecha { get; set; }
        public string? ComprobanteTipoAbreviacion { get; set; }
        public string? ComprobanteNumero { get; set; }
        public decimal? DocPagoTotalSoles { get; set; }
        public decimal? DocPagoTotalDolares { get; set; }
        public string? CajaCodigo { get; set; }
        public string? CajaNombre { get; set; }
        public string? ConceptoOperacionCodigo { get; set; }
        public string? ConceptoOperacionDescripcion { get; set; }
        public string DocumentoCobrarPagarTipoAbreviacion { get; set; } = null!;
        public string DocumentoCobrarPagarNumero { get; set; } = null!;
        public string? MedioDePagoNumero { get; set; }
        public string? MedioDePagoTipoCodigo { get; set; }
        public string? MedioDePagoTipoDescripcion { get; set; }
        public string? ItemComprobanteCuentaNumero { get; set; }
        public string? ItemComprobanteGlosa { get; set; }
        public decimal? ItemComprobanteCargoSoles { get; set; }
        public decimal? ItemComprobanteAbonoSoles { get; set; }
        public decimal? ItemComprobanteCargoDolares { get; set; }
        public decimal? ItemComprobanteAbonoDolares { get; set; }
        public int? CajaId { get; set; }
        public int? ConceptoOperacionId { get; set; }
        public int? MedioDePagoTipoId { get; set; }
        public int? ComprobanteId { get; set; }
        public int IdtipoPersona { get; set; }
        public int? ComprobanteSucursalId { get; set; }
        public string? CpVentaTipo { get; set; }
        public string? CpVentaNumero { get; set; }
        public string? VendedorCodigo { get; set; }
        public string? VendedorNombre { get; set; }
        public int? VendedorDiasComision { get; set; }
        public string FuerzaCodigo { get; set; } = null!;
        public string FuerzaNombre { get; set; } = null!;
        public string GrupoCodigo { get; set; } = null!;
        public string GrupoNombre { get; set; } = null!;
        public string ZonaVentaCodigo { get; set; } = null!;
        public string ZonaVentaNombre { get; set; } = null!;
        public bool FueraRuta { get; set; }
        public string UnidadNegocio { get; set; } = null!;
        public decimal PorcenComision { get; set; }
        public string ModalidadCreditoCodigo { get; set; } = null!;
        public string ModalidadCreditoNombre { get; set; } = null!;
        public string CpVentaFormaPago { get; set; } = null!;
        public DateTime? CpVentaFechaVencimiento { get; set; }
        public DateTime? CpVentaFechaEmision { get; set; }
        public int? DiasVencido { get; set; }
        public string? TipoCpCobrarPagar { get; set; }
    }
}
