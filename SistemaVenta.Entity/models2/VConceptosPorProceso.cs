using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VConceptosPorProceso
    {
        public int Idproceso { get; set; }
        public string Proceso { get; set; } = null!;
        public int IdtipoProceso { get; set; }
        public string? TextoProceso { get; set; }
        public int IdpasosProceso { get; set; }
        public string Pasos { get; set; } = null!;
        public int PasosOrden { get; set; }
        public string? TextPaso { get; set; }
        public string ConceptoCodigo { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string TipoCpAsociado { get; set; } = null!;
        public string OrigenDestino { get; set; } = null!;
        public int Sistema { get; set; }
        public bool? TieneCpInventario { get; set; }
        public bool? TieneCpCaja { get; set; }
        public bool? TieneCpCobrarPagar { get; set; }
        public bool? TieneCpOrigen { get; set; }
        public bool? Contabilizable { get; set; }
        public bool? Activo { get; set; }
        public string? CreadoPartirDe { get; set; }
        public string? Detalle { get; set; }
        public string? VoucherContable { get; set; }
        public string? RedondeoCargo { get; set; }
        public string? RedondeoAbono { get; set; }
        public string? AuxiliarRedondeo { get; set; }
        public bool? TipoCambioEnComprobante { get; set; }
        public string? RutaTipoCambio { get; set; }
        public int? Idconcepto { get; set; }
    }
}
