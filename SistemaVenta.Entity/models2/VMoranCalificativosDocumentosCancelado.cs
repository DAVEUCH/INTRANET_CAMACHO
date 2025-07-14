using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranCalificativosDocumentosCancelado
    {
        public int? ClienteId { get; set; }
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public string? VendedorCodigo { get; set; }
        public string? VendedorNombre { get; set; }
        public int? VendedorId { get; set; }
        public int? VendedorFuerzaId { get; set; }
        public string? VendedorFuerzaNombre { get; set; }
        public string? VendedorfuerzaCodigo { get; set; }
        public int? SupervisorId { get; set; }
        public string? SupervisorCodigo { get; set; }
        public string? SupervisorNombre { get; set; }
        public string? LineaCreditoCodigo { get; set; }
        public string? LineaCreditoNombre { get; set; }
        public decimal? LineaCreditoTotal { get; set; }
        public decimal? LineaCreditoSaldo { get; set; }
        public string ComprobanteNumero { get; set; } = null!;
        public decimal MontoCancelado { get; set; }
        public decimal? ComprobanteTotal { get; set; }
        public decimal? ComprobanteSaldo { get; set; }
        public DateTime? ComprobanteFechaEmision { get; set; }
        public DateTime? ComprobanteFechaAceptacion { get; set; }
        public DateTime ComprobanteFechaCancelacion { get; set; }
        public string ComprobanteCalificativoPago { get; set; } = null!;
        public string? ModalidadCreditoCodigo { get; set; }
        public DateTime? FechaReporte { get; set; }
    }
}
