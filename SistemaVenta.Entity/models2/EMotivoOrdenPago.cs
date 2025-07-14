using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EMotivoOrdenPago
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public bool? Activo { get; set; }
    }
}
