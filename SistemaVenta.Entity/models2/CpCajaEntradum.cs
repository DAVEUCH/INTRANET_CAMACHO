using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpCajaEntradum
    {
        public CpCajaEntradum()
        {
            CargoCobranzas = new HashSet<CargoCobranza>();
            CobranzaConsolidadoCargas = new HashSet<CobranzaConsolidadoCarga>();
        }

        public int Pkid { get; set; }
        public int Idcaja { get; set; }
        public bool PagoDetraccion { get; set; }
        public decimal TotalSoles { get; set; }
        public decimal TotalDolares { get; set; }
        public bool PercepcionAplicada { get; set; }
        public string ConformidadEntrega { get; set; } = null!;

        public virtual Caja IdcajaNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
        public virtual ICollection<CargoCobranza> CargoCobranzas { get; set; }
        public virtual ICollection<CobranzaConsolidadoCarga> CobranzaConsolidadoCargas { get; set; }
    }
}
