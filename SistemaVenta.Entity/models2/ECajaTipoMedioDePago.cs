using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECajaTipoMedioDePago
    {
        public int TiposMedioDePagoId { get; set; }
        public int Idcaja { get; set; }
        public int TiposMedioDePagoIdtipoMedioDePago { get; set; }
        public bool TiposMedioDePagoEmision { get; set; }
        public bool TiposMedioDePagoRecepcion { get; set; }
        public bool TiposMedioDePagoNumeracion { get; set; }
    }
}
