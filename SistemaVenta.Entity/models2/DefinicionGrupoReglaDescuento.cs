using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefinicionGrupoReglaDescuento
    {
        public DefinicionGrupoReglaDescuento()
        {
            DefinicionReglaDescuento2s = new HashSet<DefinicionReglaDescuento2>();
        }

        public int Pkid { get; set; }
        public string Enlace { get; set; } = null!;
        public int IddefinicionDescuento2 { get; set; }

        public virtual DefinicionDescuento2 IddefinicionDescuento2Navigation { get; set; } = null!;
        public virtual ICollection<DefinicionReglaDescuento2> DefinicionReglaDescuento2s { get; set; }
    }
}
