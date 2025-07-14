using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptDocCobrarPagarAbono
    {
        public int DocumentoCargoId { get; set; }
        public DateTime DocumentoAbonoFecha { get; set; }
        public decimal? Abono { get; set; }
    }
}
