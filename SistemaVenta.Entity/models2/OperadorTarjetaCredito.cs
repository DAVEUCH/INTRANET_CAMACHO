using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class OperadorTarjetaCredito
    {
        public OperadorTarjetaCredito()
        {
            TarjetaCreditos = new HashSet<TarjetaCredito>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<TarjetaCredito> TarjetaCreditos { get; set; }
    }
}
