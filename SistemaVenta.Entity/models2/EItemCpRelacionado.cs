using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemCpRelacionado
    {
        public int ItemsCpRelacionadosIditemCpRelacionado { get; set; }
        public string ItemsCpRelacionadosIdtipoItemCpRelacionado { get; set; } = null!;
        public decimal ItemsCpRelacionadosCantidadMonto { get; set; }
        public int IditemCp { get; set; }
        public int Idcp { get; set; }
    }
}
