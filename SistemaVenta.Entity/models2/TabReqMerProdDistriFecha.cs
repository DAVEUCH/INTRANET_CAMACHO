using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabReqMerProdDistriFecha
    {
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int Idsucursal { get; set; }
        public string Aentrada { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int? Pdv02UnidadReqMat { get; set; }
        public int? Pdv04UnidadReqMat { get; set; }
        public int? Pdv05UnidadReqMat { get; set; }
        public int? Pdv06UnidadReqMat { get; set; }
        public int? Pdv07UnidadReqMat { get; set; }
        public int? Pdv09UnidadReqMat { get; set; }
        public DateTime? FechaSigDistri { get; set; }
        public int? CantUnidadVendida { get; set; }
        public decimal? CunidadStockAnterior { get; set; }
        public decimal? CunidadStockPosterior { get; set; }
        public DateTime? FechaSigDistri2 { get; set; }
        public int? MesesTranscurreDistri { get; set; }
    }
}
