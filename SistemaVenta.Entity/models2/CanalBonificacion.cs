using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CanalBonificacion
    {
        public int Pkid { get; set; }
        public int Idbonificacion { get; set; }
        public int Idcanal { get; set; }

        public virtual Bonificacion IdbonificacionNavigation { get; set; } = null!;
        public virtual CategoriaCliente IdcanalNavigation { get; set; } = null!;
    }
}
