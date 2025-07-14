using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Descuento
    {
        public Descuento()
        {
            CanalDescuentos = new HashSet<CanalDescuento>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public bool PorCanal { get; set; }
        public bool Afines { get; set; }
        public bool PorCantidad { get; set; }
        public bool TieneVigencia { get; set; }

        public virtual ICollection<CanalDescuento> CanalDescuentos { get; set; }
    }
}
