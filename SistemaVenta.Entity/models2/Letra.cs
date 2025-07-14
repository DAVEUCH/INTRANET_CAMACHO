using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Letra
    {
        public int Pkid { get; set; }
        public int Idbanco { get; set; }
        public int Idestado { get; set; }
        public string Direccion { get; set; } = null!;
        public bool EnBanco { get; set; }
        public string NumeroUnicoBanco { get; set; } = null!;

        public virtual Estado IdestadoNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}
