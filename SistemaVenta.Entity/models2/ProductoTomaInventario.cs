using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoTomaInventario
    {
        public int Pkid { get; set; }
        public int IdtomaInventario { get; set; }
        public int Idproducto { get; set; }
        public int Cantidad { get; set; }
        public int Stock { get; set; }
        public int Diferencia { get; set; }
        public int CantidadModificada { get; set; }
        public bool Editar { get; set; }

        public virtual Producto IdproductoNavigation { get; set; } = null!;
        public virtual TomaInventario IdtomaInventarioNavigation { get; set; } = null!;
    }
}
