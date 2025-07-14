using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpRelacionado
    {
        public int IditemCp { get; set; }
        public int IditemCpRelacionado { get; set; }
        public string IdtipoItemCpRelacionado { get; set; } = null!;
        public decimal CantidadMonto { get; set; }

        public virtual ItemCp IditemCpNavigation { get; set; } = null!;
        public virtual ItemCp IditemCpRelacionadoNavigation { get; set; } = null!;
    }
}
