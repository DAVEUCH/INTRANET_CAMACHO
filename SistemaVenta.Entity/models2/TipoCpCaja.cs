using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoCpCaja
    {
        public int Pkid { get; set; }
        public int Idcaja { get; set; }
        public bool RestringirCaja { get; set; }
        public string TipoMovimiento { get; set; } = null!;
        public bool RestringirDocumentoPersona { get; set; }
        public bool PagoDetraccion { get; set; }
        public bool? RestringirCajaCabecera { get; set; }
        public bool AmortizacionTotal { get; set; }
        public bool RestringirAplicacionDocumentos { get; set; }

        public virtual TipoCp Pk { get; set; } = null!;
    }
}
