using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemCpVentaConsolidadoCarga
    {
        public int ItemsCpVentaPkid { get; set; }
        public int ItemsCpVentaIdcpVenta { get; set; }
        public int ItemsCpVentaId { get; set; }
        public int ItemsCpVentaIdconsolidadoCarga { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int Id { get; set; }
        public int IdcpVenta { get; set; }
        public bool ItemsCpVentaEntrega { get; set; }
        public DateTime ItemsCpVentaFechaAceptacion { get; set; }
    }
}
