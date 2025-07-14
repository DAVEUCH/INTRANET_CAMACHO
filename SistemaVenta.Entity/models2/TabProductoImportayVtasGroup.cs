using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabProductoImportayVtasGroup
    {
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public DateTime? Fecha1Er { get; set; }
        public DateTime? FechaUlt { get; set; }
        public int? TransaccionesCompras { get; set; }
        public int CunidadVtaTot { get; set; }
        public int CunidadVtaProm { get; set; }
        public int? CunidadComproTot { get; set; }
        public decimal? CunidadComproProm { get; set; }
        public int? CunidadStockAnteriorTot { get; set; }
        public decimal? CunidadStockAnteriorProm { get; set; }
        public decimal? IndiceRotacion { get; set; }
        public int? CunidadComproImp { get; set; }
        public int? CunidadComproCpm { get; set; }
        public int? CunidadComproCp { get; set; }
        public int? CunidadComproVinc { get; set; }
        public decimal? CunidadStockPosteriorProm { get; set; }
        public int? RoturaStock { get; set; }
        public decimal? MesTranscurreImportProm { get; set; }
        public int? TransaccionesVentas { get; set; }
    }
}
