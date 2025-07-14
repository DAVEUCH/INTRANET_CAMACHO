using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VPercepcionDeComprobanteDma
    {
        public int Idpercepcion { get; set; }
        public string NumeroPercepcion { get; set; } = null!;
        public string AbreviacionPercepcion { get; set; } = null!;
        public int Idcp { get; set; }
    }
}
