using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoPedido
    {
        public int Pkid { get; set; }
        public int Idalmacen { get; set; }
        public bool RequiereAprobacion { get; set; }
        public bool RequiereCliente { get; set; }
        public bool SobregirarStockDisponible { get; set; }
        public bool RestringirAlmacen { get; set; }
        public bool FueraDeRuta { get; set; }
        public bool AplicaDistribucion { get; set; }

        public virtual Almacen IdalmacenNavigation { get; set; } = null!;
        public virtual TipoCp Pk { get; set; } = null!;
    }
}
