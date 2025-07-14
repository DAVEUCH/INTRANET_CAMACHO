using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDefinicionSubActividad
    {
        public string Id { get; set; } = null!;
        public string Idensamblado { get; set; } = null!;
        public string Clase { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Especificacion { get; set; } = null!;
    }
}
