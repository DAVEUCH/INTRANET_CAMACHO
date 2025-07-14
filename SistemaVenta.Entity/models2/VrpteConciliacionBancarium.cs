using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteConciliacionBancarium
    {
        public int ComprobanteId { get; set; }
        public DateTime ComprobanteFecha { get; set; }
        public int ComprobanteCajaId { get; set; }
        public string ComprobanteCajaCodigo { get; set; } = null!;
        public string ComprobanteCajaNombre { get; set; } = null!;
        public string MedioDePagoTipoCodigo { get; set; } = null!;
        public string MedioDePagoTipoDescripcion { get; set; } = null!;
        public string MedioDePagoNumero { get; set; } = null!;
        public DateTime MedioDePagoFechaEmision { get; set; }
        public DateTime MedioDePagoFechaPago { get; set; }
        public string MedioDePagoMonedaCodigo { get; set; } = null!;
        public string MedioDePagoMonedaSimbolo { get; set; } = null!;
        public bool MedioDePagoMonedaBase { get; set; }
        public string MedioDePagoPersonaCodigo { get; set; } = null!;
        public string MedioDePagoPersonaNombre { get; set; } = null!;
        public string MedioDePagoBancoCodigo { get; set; } = null!;
        public string MedioDePagoBancoNombre { get; set; } = null!;
        public string MedioDePagoOperadorTarjetaCreditoCodigo { get; set; } = null!;
        public string MedioDePagoOperadorTarjetaCreditoDescripcion { get; set; } = null!;
        public decimal? MedioDePagoCargo { get; set; }
        public decimal? MedioDePagoAbono { get; set; }
        public decimal MedioDePagoTotal { get; set; }
        public DateTime MedioDePagoFechaConfirmacionOrechazo { get; set; }
        public string ComprobanteOrigenTipoDocumento { get; set; } = null!;
        public string ComprobanteOrigenNumero { get; set; } = null!;
        public int Pkid { get; set; }
    }
}
