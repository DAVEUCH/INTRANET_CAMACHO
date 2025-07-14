using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsuarioRangoAprobacion
    {
        public int Pkid { get; set; }
        public int Idusuario { get; set; }
        public int IdrangoAprobacionOrdenCompra { get; set; }

        public virtual RangoAprobacionOrdenCompra IdrangoAprobacionOrdenCompraNavigation { get; set; } = null!;
    }
}
