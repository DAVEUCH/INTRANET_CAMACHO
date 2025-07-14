using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VImpCpCajaSalidum
    {
        public int ComprobanteId { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteNumCpContable { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public string? ComprobanteTipoPersona { get; set; }
        public string CoprobantePersonaNombre { get; set; } = null!;
        public string? CuentaNumero { get; set; }
        public string? CuentaDescripcion { get; set; }
        public string CargoAbonoDocPagoNumCp { get; set; } = null!;
        public string CargoAbonoDocPagoMoneda { get; set; } = null!;
        public decimal? CargoAbonoImporte { get; set; }
        public decimal CargoAbonoCargo { get; set; }
        public decimal CargoAbonoAbono { get; set; }
        public string CargoAbonoDocPagoPersonaNombre { get; set; } = null!;
        public string? Nombre { get; set; }
        public decimal TotalSoles { get; set; }
        public decimal TotalDolares { get; set; }
        public string CajaCodigo { get; set; } = null!;
        public string CajaNombre { get; set; } = null!;
        public decimal TipoCambio { get; set; }
        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public int IdtipoCp { get; set; }
        public string ConceptoCodigo { get; set; } = null!;
        public string ConceptoDescripcion { get; set; } = null!;
        public string MedioDePagoNumero { get; set; } = null!;
    }
}
