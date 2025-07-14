using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteLibroDiario
    {
        public string VoucherContableTipo { get; set; } = null!;
        public string VoucherContableNumero { get; set; } = null!;
        public DateTime VoucherContableFecha { get; set; }
        public int VoucherContablePeriodoId { get; set; }
        public string VoucherContableComprobanteOrigenTipo { get; set; } = null!;
        public string VoucherContableComprobanteOrigenNumero { get; set; } = null!;
        public string AsientoGlosa { get; set; } = null!;
        public string AsientoLibroCodigo { get; set; } = null!;
        public string? CargoAbonoCuentaNumero { get; set; }
        public string? CargoAbonoCuentaDescripcion { get; set; }
        public decimal CargoAbonoCargo { get; set; }
        public decimal CargoAbonoAbono { get; set; }
        public decimal CargoAbonoCargoMonedaBase { get; set; }
        public decimal CargoAbonoAbonoMonedaBase { get; set; }
        public string CargoAbonoDocumentoPagoTipo { get; set; } = null!;
        public string CargoAbonoDocumentoPagoNumero { get; set; } = null!;
        public int CargoAbonoMonedaId { get; set; }
        public bool ResumirEnLibroDiario { get; set; }
    }
}
