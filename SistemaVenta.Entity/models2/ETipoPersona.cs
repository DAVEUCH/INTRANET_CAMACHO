using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ETipoPersona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Compras { get; set; }
        public bool Ventas { get; set; }
        public bool Inventario { get; set; }
        public bool Caja { get; set; }
        public bool Ninguno { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
    }
}
