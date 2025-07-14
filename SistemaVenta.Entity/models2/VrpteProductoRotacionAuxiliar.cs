using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteProductoRotacionAuxiliar
    {
        public DateTime ComprobanteFecha { get; set; }
        public int Idproducto { get; set; }
        public int? CantidadBase { get; set; }
        public int ComprobanteSucursalId { get; set; }
        public int ComprobanteAlmacenId { get; set; }
        public int? Idproveedor { get; set; }
    }
}
