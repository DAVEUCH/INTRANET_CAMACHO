using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranCobranzaVendedore
    {
        public int? IdtipoPersona { get; set; }
        public string? TipoPersona { get; set; }
        public int ConceptoOperacionId { get; set; }
        public string ConceptoOperacionCodigo { get; set; } = null!;
        public string ConceptoOperacionDescripcion { get; set; } = null!;
        public int CpCobranzaCobradorId { get; set; }
        public string CpCobranzaCobradorCodigo { get; set; } = null!;
        public string CpCobranzaCobradorNombre { get; set; } = null!;
        public int CpCobranzaId { get; set; }
        public DateTime CpCobranzaFecha { get; set; }
        public string CoCobranzaTipoAbreviacion { get; set; } = null!;
        public string CpCobranzaNumero { get; set; } = null!;
        public string CpCobranzaCajaCodigo { get; set; } = null!;
        public string CpCobranzaCajaNombre { get; set; } = null!;
        public int CpCobranzaCajaId { get; set; }
        public int CpCobranzaSucursalId { get; set; }
        public int? DocumentoCobrarPagarPersonaId { get; set; }
        public string DocumentoCobrarPagarPersonaCodigo { get; set; } = null!;
        public string DocumentoCobrarPagarPersonaNombre { get; set; } = null!;
        public string DocumentoCobrarPagarTipoAbreviacion { get; set; } = null!;
        public string DocumentoCobrarPagarNumero { get; set; } = null!;
        public decimal? DocPagoTotalSoles { get; set; }
        public int MedioDePagoTipoId { get; set; }
        public string MedioDePagoNumero { get; set; } = null!;
        public string MedioDePagoTipoCodigo { get; set; } = null!;
        public string MedioDePagoTipoDescripcion { get; set; } = null!;
        public decimal? ItemComprobanteAmortiza { get; set; }
        public string? TipoCpCobrarPagar { get; set; }
    }
}
