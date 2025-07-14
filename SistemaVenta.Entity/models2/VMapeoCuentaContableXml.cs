using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMapeoCuentaContableXml
    {
        public int Id { get; set; }
        public int CuentaContable { get; set; }
        public int MapeoPadre { get; set; }
        public string Tipo { get; set; } = null!;
        public int SubCuentas { get; set; }
        public string Clave { get; set; } = null!;
        public int Nivel { get; set; }
    }
}
