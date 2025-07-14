using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoCanjeLetra
    {
        public int Pkid { get; set; }
        public bool RestringirDocumentoPersona { get; set; }

        public virtual TipoCp Pk { get; set; } = null!;
    }
}
