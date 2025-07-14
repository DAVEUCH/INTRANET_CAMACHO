using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECategoriaCliente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool PorDefecto { get; set; }
        public bool Activo { get; set; }
    }
}
