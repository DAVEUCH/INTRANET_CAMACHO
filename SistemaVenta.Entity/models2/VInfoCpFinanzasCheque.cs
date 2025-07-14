using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpFinanzasCheque
    {
        public int ComprobanteId { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteNumCpContable { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public string? ComprobanteTipoOrigenDestino { get; set; }
        public string? CoprobanteOrigenDestinoNombre { get; set; }
        public string? CuentaNumero { get; set; }
        public string? CuentaDescripcion { get; set; }
        public string CargoAbonoDocPagoNumCp { get; set; } = null!;
        public string CargoAbonoDocPagoMoneda { get; set; } = null!;
        public decimal? CargoAbonoImporte { get; set; }
        public decimal CargoAbonoCargo { get; set; }
        public decimal CargoAbonoAbono { get; set; }
        public string CargoAbonoDocPagoOrigenDestinoNombre { get; set; } = null!;
        public string? Nombre { get; set; }
        public int IdtipoCp { get; set; }
        public decimal TipoCambio { get; set; }
        public string ConceptoCodigo { get; set; } = null!;
        public string ConceptoDescripcion { get; set; } = null!;
        public DateTime MedioDePagoEmision { get; set; }
        public DateTime MedioDePagoVencimiento { get; set; }
        public string MedioDePagoObservacion { get; set; } = null!;
        public decimal MedioDePagoTotal { get; set; }
        public string MedioDePagoOrigenDestinoNombre { get; set; } = null!;
        public string? MedioDePagoBanco { get; set; }
        public string CargoAbonoDocPagoPersonaCodigo { get; set; } = null!;
        public string? MedioDePagoTotalEnLetras { get; set; }
        public string MedioDePagoNumero { get; set; } = null!;
    }
}
