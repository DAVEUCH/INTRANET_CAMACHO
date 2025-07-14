using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EProvincium
    {
        public int Id { get; set; }
        public int Iddepartamento { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Ubigeo { get; set; } = null!;
    }
}
