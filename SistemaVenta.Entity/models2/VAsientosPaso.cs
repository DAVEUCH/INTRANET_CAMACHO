using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAsientosPaso
    {
        public int Idproceso { get; set; }
        public int IdcptoOperacion { get; set; }
        public int IdasientoTipo { get; set; }
        public int Orden1 { get; set; }
        public string Cuenta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string CargoAbono { get; set; } = null!;
        public string RutaMonto { get; set; } = null!;
        public string RutaCuentaContable { get; set; } = null!;
        public string RutaCentroDeCosto { get; set; } = null!;
        public bool Contabilizable { get; set; }
        public int? Orden { get; set; }
    }
}
