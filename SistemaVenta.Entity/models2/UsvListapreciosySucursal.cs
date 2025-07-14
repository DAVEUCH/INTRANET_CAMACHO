using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvListapreciosySucursal
    {
        public int IdlistaPrecios { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Idsucursal { get; set; }
    }
}
