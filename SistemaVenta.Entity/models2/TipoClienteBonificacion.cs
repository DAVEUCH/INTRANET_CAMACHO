using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoClienteBonificacion
    {
        public int Pkid { get; set; }
        public int Idbonificacion { get; set; }
        public int IdtipoCliente { get; set; }

        public virtual Bonificacion IdbonificacionNavigation { get; set; } = null!;
        public virtual TipoCliente IdtipoClienteNavigation { get; set; } = null!;
    }
}
