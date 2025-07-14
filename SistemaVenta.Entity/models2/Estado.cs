using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Estado
    {
        public Estado()
        {
            CanjeLetras = new HashSet<CanjeLetra>();
            Letras = new HashSet<Letra>();
        }

        public int Pkid { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<CanjeLetra> CanjeLetras { get; set; }
        public virtual ICollection<Letra> Letras { get; set; }
    }
}
