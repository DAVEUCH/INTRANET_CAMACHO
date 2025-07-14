using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoVoucherContable
    {
        public int ComprobanteId { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteNumCpContable { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public string? ComprobanteTipoPersona { get; set; }
        public string? CoprobantePersonaNombre { get; set; }
        public string? CuentaNumero { get; set; }
        public string? CuentaDescripcion { get; set; }
        public string CargoAbonoDocPagoNumCp { get; set; } = null!;
        public string CargoAbonoDocPagoMoneda { get; set; } = null!;
        public decimal? CargoAbonoImporte { get; set; }
        public decimal CargoAbonoCargo { get; set; }
        public decimal CargoAbonoAbono { get; set; }
        public string CargoAbonoDocPagoPersonaNombre { get; set; } = null!;
        public string? Nombre { get; set; }
        public string CargoAbonoGlosa { get; set; } = null!;
        public string? TipoCp { get; set; }
        public string VoucherContableNumCp { get; set; } = null!;
        public string VoucherContableTipoCpCodigo { get; set; } = null!;
        public string VoucherContableTipoCpDescipcion { get; set; } = null!;
        public string VoucherContableTipoCpAbv { get; set; } = null!;
        public int VoucherContableTipoCpId { get; set; }
    }
}
