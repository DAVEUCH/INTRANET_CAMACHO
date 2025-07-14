using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptLiinformacionDocumentoAbonoVenta
    {
        public int DocumentoCargoId { get; set; }
        public int DocumentoAbonoItemId { get; set; }
        public int DocumentoAbonoId { get; set; }
        public string DocumentoAbonoTipoCp { get; set; } = null!;
        public DateTime DocumentoAbonoFecha { get; set; }
        public DateTime DocumentoAbonoFechaEmision { get; set; }
        public string DocumentoAbonoNumero { get; set; } = null!;
        public string DocumentoAbonoObservacion { get; set; } = null!;
        public string? DocumentoAbonoNombre { get; set; }
        public int DocumentoAbonoMonedaId { get; set; }
        public string DocumentoAbonoMonedaDescripcion { get; set; } = null!;
        public decimal TipoCambio { get; set; }
        public string DocumentoAbonoMonedaSimbolo { get; set; } = null!;
        public bool DocumentoAbonoMonedaEsBase { get; set; }
        public string DocumentoAbonoTipo { get; set; } = null!;
    }
}
