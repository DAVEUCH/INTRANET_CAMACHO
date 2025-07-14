using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Incoterm
    {
        public Incoterm()
        {
            Duas = new HashSet<Dua>();
            OrdenCompras = new HashSet<OrdenCompra>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Dua> Duas { get; set; }
        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
    }
}
