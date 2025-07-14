using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ENumeracionMedioPago
    {
        public int Id { get; set; }
        public int? Idcaja { get; set; }
        public bool? Activo { get; set; }
        public int? NumeroInicio { get; set; }
        public int? NumeroFin { get; set; }
        public int? Numero { get; set; }
        public int? CantidadDigitos { get; set; }
    }
}
