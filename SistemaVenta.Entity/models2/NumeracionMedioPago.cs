using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class NumeracionMedioPago
    {
        public NumeracionMedioPago()
        {
            ItemNumeracionMedioPagos = new HashSet<ItemNumeracionMedioPago>();
        }

        public int Pkid { get; set; }
        public int? Idcaja { get; set; }
        public bool? Activo { get; set; }
        public int? NumeroInicio { get; set; }
        public int? NumeroFin { get; set; }
        public int? Numero { get; set; }
        public int? CantidadDigitos { get; set; }

        public virtual ICollection<ItemNumeracionMedioPago> ItemNumeracionMedioPagos { get; set; }
    }
}
