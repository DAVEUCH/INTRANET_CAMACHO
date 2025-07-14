using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoComprobantePago
    {
        public TipoComprobantePago()
        {
            TipoCps = new HashSet<TipoCp>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<TipoCp> TipoCps { get; set; }
    }
}
