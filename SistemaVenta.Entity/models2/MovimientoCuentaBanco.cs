using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MovimientoCuentaBanco
    {
        public MovimientoCuentaBanco()
        {
            ItemMovimientoCuentaBancos = new HashSet<ItemMovimientoCuentaBanco>();
        }

        public int Pkid { get; set; }
        public DateTime FechaImportacion { get; set; }
        public int Idcaja { get; set; }
        public int? Idmoneda { get; set; }

        public virtual Caja IdcajaNavigation { get; set; } = null!;
        public virtual Monedum? IdmonedaNavigation { get; set; }
        public virtual ICollection<ItemMovimientoCuentaBanco> ItemMovimientoCuentaBancos { get; set; }
    }
}
