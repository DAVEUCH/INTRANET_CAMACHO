using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoLetraGral
    {
        public int ComprobanteId { get; set; }
        public string ComprobanteTipoCpAbreviacion { get; set; } = null!;
        public string ComprobanteNumero { get; set; } = null!;
        public string ComprobantePersonaombre { get; set; } = null!;
        public string ComprobanteSucursalNombre { get; set; } = null!;
        public DateTime ComprobanteFechaEmision { get; set; }
        public DateTime ComprobanteFechaVencimiento { get; set; }
        public string ComprobanteMonedaSimbolo { get; set; } = null!;
        public decimal ComprobanteTotal { get; set; }
        public decimal ComprobanteSaldo { get; set; }
        public string ComprobanteEstado { get; set; } = null!;
        public bool ComprobanteAnulado { get; set; }
        public bool ComprobanteTercero { get; set; }
        public string? ComprobanteMontoEnLetras { get; set; }
        public string ComprobanteMonedaDescripcion { get; set; } = null!;
        public string DocIdentidad { get; set; } = null!;
        public string DireccionDestino { get; set; } = null!;
        public string DistritoEmision { get; set; } = null!;
    }
}
