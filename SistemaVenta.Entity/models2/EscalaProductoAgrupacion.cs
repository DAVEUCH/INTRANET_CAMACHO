using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EscalaProductoAgrupacion
    {
        public int Pkid { get; set; }
        public decimal Precio { get; set; }
        public bool Bonificacion { get; set; }
        public int IdproductoAgrupacion { get; set; }
        public int Idescala { get; set; }
        public decimal Porcentaje { get; set; }

        public virtual ProductoAgrupacion IdproductoAgrupacionNavigation { get; set; } = null!;
    }
}
