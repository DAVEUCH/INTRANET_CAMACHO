using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemDistribucionCosto
    {
        public int ItemDistribucionCostoId { get; set; }
        public int Pkid { get; set; }
        public int ItemDistribucionCostoIddistribucionCostosCuentasContables { get; set; }
        public int IddistribucionCostosCuentasContables { get; set; }
        public int ItemDistribucionCostoIddistribucionCostosProductos { get; set; }
        public int IddistribucionCostosProductos { get; set; }
        public int IddistribucionCosto { get; set; }
        public decimal? ItemDistribucionCostoPorcentaje { get; set; }
        public decimal? Porcentaje { get; set; }
        public string? ItemDistribucionCostoPosicion { get; set; }
        public string? Posicion { get; set; }
    }
}
