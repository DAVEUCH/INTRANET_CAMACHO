using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemNumeracionMedioPago
    {
        public int Id { get; set; }
        public int? IdtipoMedioDePago { get; set; }
        public int? IdnumeracionMedioPago { get; set; }
        public int? TiposMedioPagoIdtipoMedioDePago { get; set; }
        public int? TiposMedioPagoIdnumeracionMedioPago { get; set; }
        public int TiposMedioPagoId { get; set; }
    }
}
