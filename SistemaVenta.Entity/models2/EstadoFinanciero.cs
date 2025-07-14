using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EstadoFinanciero
    {
        public EstadoFinanciero()
        {
            EstadoFinancieroRubros = new HashSet<EstadoFinancieroRubro>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Niveles { get; set; }
        public string Codigo { get; set; } = null!;

        public virtual ICollection<EstadoFinancieroRubro> EstadoFinancieroRubros { get; set; }
    }
}
