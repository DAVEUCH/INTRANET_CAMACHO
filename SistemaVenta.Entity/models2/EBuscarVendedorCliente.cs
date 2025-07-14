using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EBuscarVendedorCliente
    {
        public string Descripcion { get; set; } = null!;
        public int Idvendedor { get; set; }
        public int Idcliente { get; set; }
        public string Nombre { get; set; } = null!;
        public string DiaDeSemana { get; set; } = null!;
    }
}
