using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EstadoFinancieroRubro
    {
        public EstadoFinancieroRubro()
        {
            EstadoFinancieroRubroCuentaContables = new HashSet<EstadoFinancieroRubroCuentaContable>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Orden { get; set; }
        public int IdestadoFinanciero { get; set; }
        public int? IdestadoFinancieroRubroPadre { get; set; }

        public virtual EstadoFinanciero IdestadoFinancieroNavigation { get; set; } = null!;
        public virtual ICollection<EstadoFinancieroRubroCuentaContable> EstadoFinancieroRubroCuentaContables { get; set; }
    }
}
