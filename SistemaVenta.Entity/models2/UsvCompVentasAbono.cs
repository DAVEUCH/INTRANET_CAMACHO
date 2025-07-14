using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCompVentasAbono
    {
        public int DocCargoId { get; set; }
        public int DocAbonoItemId { get; set; }
        public int DocAbonoId { get; set; }
        public string DocAbonoTipoCp { get; set; } = null!;
        public DateTime DocAbonoFecha { get; set; }
        public DateTime DocAbonoFechaEmision { get; set; }
        public string DocAbonoNumero { get; set; } = null!;
        public string DocAbonoObservacion { get; set; } = null!;
        public string? DocAbonoNombre { get; set; }
        public int DocAbonoMonedaId { get; set; }
        public string DocAbonoMonedaDescripcion { get; set; } = null!;
        public decimal TipoCambio { get; set; }
        public string DocAbonoMonedaSimbolo { get; set; } = null!;
        public bool DocAbonoMonedaEsBase { get; set; }
        public string DocAbonoTipo { get; set; } = null!;
    }
}
