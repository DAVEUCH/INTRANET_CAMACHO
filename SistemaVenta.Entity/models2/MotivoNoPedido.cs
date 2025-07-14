using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MotivoNoPedido
    {
        public MotivoNoPedido()
        {
            Nopedidos = new HashSet<Nopedido>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Nopedido> Nopedidos { get; set; }
    }
}
