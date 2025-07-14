using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemCpRelacionado2
    {
        public int Idcp { get; set; }
        public int ItemCpId { get; set; }
        public decimal ItemCpCantidad { get; set; }
        public int ItemCpItemCpRelacionadoIditemCp { get; set; }
        public int ItemCpItemCpRelacionadoIditemCpRelacionado { get; set; }
        public string ItemCpItemCpRelacionadoIdtipoItemCpRelacionado { get; set; } = null!;
        public decimal ItemCpItemCpRelacionadoCantidadMonto { get; set; }
    }
}
