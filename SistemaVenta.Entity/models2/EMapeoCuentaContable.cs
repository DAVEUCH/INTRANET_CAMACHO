using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EMapeoCuentaContable
    {
        public int Id { get; set; }
        public int IdmapeoCuentaContablePadre { get; set; }
        public int IdcuentaContable { get; set; }
        public string Idtipo { get; set; } = null!;
        public string Filtro { get; set; } = null!;
        public int SubCuentas { get; set; }
        public string Clave { get; set; } = null!;
        public int Nivel { get; set; }
    }
}
