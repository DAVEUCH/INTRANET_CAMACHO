using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DistribucionCosto
    {
        public DistribucionCosto()
        {
            DistribucionCostosCuentasContables = new HashSet<DistribucionCostosCuentasContable>();
            DistribucionCostosProductos = new HashSet<DistribucionCostosProducto>();
            ItemDistribucionCostos = new HashSet<ItemDistribucionCosto>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public int IdcptoOperacion { get; set; }

        public virtual ICollection<DistribucionCostosCuentasContable> DistribucionCostosCuentasContables { get; set; }
        public virtual ICollection<DistribucionCostosProducto> DistribucionCostosProductos { get; set; }
        public virtual ICollection<ItemDistribucionCosto> ItemDistribucionCostos { get; set; }
    }
}
