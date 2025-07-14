using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptProduccionMrp
    {
        public int ProductoId { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoNombre { get; set; } = null!;
        public string ProductoUnidad { get; set; } = null!;
        public int ProductoUnidadFactor { get; set; }
        public int ProductoCantidadProduccion { get; set; }
        public decimal? ProductoStock { get; set; }
        public decimal? ProductoStockPorRecibir { get; set; }
        public decimal? ProductoStockPorEntregar { get; set; }
        public string ProductoHijoCodigo { get; set; } = null!;
        public string ProductoHijoNombre { get; set; } = null!;
        public string ProductoHijoUnidadProduccion { get; set; } = null!;
        public decimal ProductoHijoCantidadProduccion { get; set; }
        public decimal? ProductoHijoStock { get; set; }
        public decimal? ProductoHijoStockPorRecibir { get; set; }
        public decimal? ProductoHijoStockPorEntregar { get; set; }
        public int ProductoHijoNivel2Id { get; set; }
        public string ProductoHijoNivel2Codigo { get; set; } = null!;
        public string ProductoHijoNivel2Nombre { get; set; } = null!;
        public string ProductoHijoNivel2Unidad { get; set; } = null!;
        public decimal ProductoHijoNivel2CantidadProduccion { get; set; }
        public decimal? ProductoHijoNivel2Stock { get; set; }
        public decimal? ProductoHijoNivel2StockPorRecibir { get; set; }
        public decimal? ProductoHijoNivel2StockPorEntregar { get; set; }
    }
}
