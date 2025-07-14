using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabReqMerProdDistriGroupSucursal2
    {
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int Idsucursal { get; set; }
        public DateTime? Fecha1Er { get; set; }
        public DateTime? FechaUlt { get; set; }
        public int? TransaccReqMat { get; set; }
        public int? TotUnidReqMat { get; set; }
        public int? CunidadVtaTot { get; set; }
        public int? Pdv02UnidadReqMat { get; set; }
        public int? Pdv04UnidadReqMat { get; set; }
        public int? Pdv05UnidadReqMat { get; set; }
        public int? Pdv06UnidadReqMat { get; set; }
        public int? Pdv07UnidadReqMat { get; set; }
        public int? Pdv09UnidadReqMat { get; set; }
        public int? Pdv02UnidadTrans { get; set; }
        public int? Pdv04UnidadTrans { get; set; }
        public int? Pdv05UnidadTrans { get; set; }
        public int? Pdv06UnidadTrans { get; set; }
        public int? Pdv07UnidadTrans { get; set; }
        public int? Pdv09UnidadTrans { get; set; }
    }
}
