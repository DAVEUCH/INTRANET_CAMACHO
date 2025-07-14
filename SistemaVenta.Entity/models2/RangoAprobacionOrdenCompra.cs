using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RangoAprobacionOrdenCompra
    {
        public RangoAprobacionOrdenCompra()
        {
            UsuarioRangoAprobacions = new HashSet<UsuarioRangoAprobacion>();
        }

        public int Pkid { get; set; }
        public int Idmoneda { get; set; }
        public decimal Hasta { get; set; }

        public virtual Monedum IdmonedaNavigation { get; set; } = null!;
        public virtual ICollection<UsuarioRangoAprobacion> UsuarioRangoAprobacions { get; set; }
    }
}
