using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvReqmaterialesSumAño
    {
        public string Codigo { get; set; } = null!;
        public string Linea { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public int? Pdv02UnidadReqMat { get; set; }
        public int? Pdv02UnidadVtas { get; set; }
        public int? Pdv04UnidadReqMat { get; set; }
        public int? Pdv04UnidadVtas { get; set; }
        public int? Pdv05UnidadReqMat { get; set; }
        public int? Pdv05UnidadVtas { get; set; }
        public int? Pdv06UnidadReqMat { get; set; }
        public int? Pdv06UnidadVtas { get; set; }
        public int? Pdv07UnidadReqMat { get; set; }
        public int? Pdv07UnidadVtas { get; set; }
        public int? Pdv09UnidadReqMat { get; set; }
        public int? Pdv09UnidadVtas { get; set; }
    }
}
