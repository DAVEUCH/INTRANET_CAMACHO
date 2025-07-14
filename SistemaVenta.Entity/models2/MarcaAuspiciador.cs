using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MarcaAuspiciador
    {
        public int Pkid { get; set; }
        public int Idmarca { get; set; }
        public int Idbonificacion { get; set; }
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public decimal CondicionDeRango { get; set; }

        public virtual Bonificacion IdbonificacionNavigation { get; set; } = null!;
        public virtual Marca IdmarcaNavigation { get; set; } = null!;
    }
}
