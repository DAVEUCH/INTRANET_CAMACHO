using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VConceptosMovStock
    {
        public int Idconcepto { get; set; }
        public int StockFisico { get; set; }
        public int StockContable { get; set; }
        public int StockPorEntregar { get; set; }
        public int StockPorRecibir { get; set; }
        public bool SugerenciaCompra { get; set; }
        public bool GestionaLote { get; set; }
        public bool CostoPromedio { get; set; }
        public int CostoPromedioCantidad { get; set; }
        public int CostoPromedioMonto { get; set; }
        public bool CostoUltimaCompra { get; set; }
        public bool CostoReferencia { get; set; }
        public bool CostoParalelo { get; set; }
        public int Idproceso { get; set; }
        public bool TieneCpInventario { get; set; }
    }
}
