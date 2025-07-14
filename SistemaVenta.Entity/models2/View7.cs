using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class View7
    {
        public int ComprobanteId { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteNumCpContable { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public string? CoprobanteOrigenDestinoNombre { get; set; }
        public string CargoAbonoDocPagoNumCp { get; set; } = null!;
        public decimal? CargoAbonoImporte { get; set; }
        public string CargoAbonoDocPagoOrigenDestinoNombre { get; set; } = null!;
        public string? Nombre { get; set; }
        public int IdtipoCp { get; set; }
        public decimal TipoCambio { get; set; }
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
