using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabReqMerProdTransfFecha
    {
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Idsucursal { get; set; }
        public string Aentrada { get; set; } = null!;
        public int IdsucursalSalida { get; set; }
        public string Asalida { get; set; } = null!;
        public int CantUnidadesReqMat { get; set; }
        public int? EsParaGci { get; set; }
    }
}
