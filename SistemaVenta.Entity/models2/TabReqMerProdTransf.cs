using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabReqMerProdTransf
    {
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int? TotalUnidadReqMat { get; set; }
        public int? Pdv02UnidadReqMat { get; set; }
        public int? Pdv04UnidadReqMat { get; set; }
        public int? Pdv05UnidadReqMat { get; set; }
        public int? Pdv06UnidadReqMat { get; set; }
        public int? Pdv07UnidadReqMat { get; set; }
        public int? Pdv09UnidadReqMat { get; set; }
    }
}
