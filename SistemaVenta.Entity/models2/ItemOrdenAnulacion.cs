using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemOrdenAnulacion
    {
        public int Pkid { get; set; }
        public int IditemCp { get; set; }
        public int Idunidad { get; set; }
        public int IdordenAnulacion { get; set; }
        public decimal Cantidad { get; set; }
        public int Idproducto { get; set; }
        public decimal PrecioUnitario { get; set; }

        public virtual ItemCp IditemCpNavigation { get; set; } = null!;
        public virtual OrdenAnulacion IdordenAnulacionNavigation { get; set; } = null!;
        public virtual Unidad IdunidadNavigation { get; set; } = null!;
    }
}
