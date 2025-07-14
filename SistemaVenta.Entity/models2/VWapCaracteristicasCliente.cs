using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VWapCaracteristicasCliente
    {
        public int Idcliente { get; set; }
        public string Caracteristica1 { get; set; } = null!;
        public string Caracteristica2 { get; set; } = null!;
        public string Caracteristica3 { get; set; } = null!;
        public string Caracteristica4 { get; set; } = null!;
    }
}
