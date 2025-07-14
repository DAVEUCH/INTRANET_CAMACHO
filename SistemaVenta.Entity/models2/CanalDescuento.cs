using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CanalDescuento
    {
        public int Pkid { get; set; }
        public int Iddescuento { get; set; }
        public int Idcanal { get; set; }

        public virtual CategoriaCliente IdcanalNavigation { get; set; } = null!;
        public virtual Descuento IddescuentoNavigation { get; set; } = null!;
    }
}
