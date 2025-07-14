using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Impuesto
    {
        public Impuesto()
        {
            Cps = new HashSet<Cp>();
            Duas = new HashSet<Dua>();
            ImpuestoProductoServicios = new HashSet<ImpuestoProductoServicio>();
            ListaPreciosProveedors = new HashSet<ListaPreciosProveedor>();
            TipoCps = new HashSet<TipoCp>();
            TipoDuas = new HashSet<TipoDua>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public decimal Valor { get; set; }
        public bool AplicableAproducto { get; set; }
        public bool Retencion { get; set; }

        public virtual ICollection<Cp> Cps { get; set; }
        public virtual ICollection<Dua> Duas { get; set; }
        public virtual ICollection<ImpuestoProductoServicio> ImpuestoProductoServicios { get; set; }
        public virtual ICollection<ListaPreciosProveedor> ListaPreciosProveedors { get; set; }
        public virtual ICollection<TipoCp> TipoCps { get; set; }
        public virtual ICollection<TipoDua> TipoDuas { get; set; }
    }
}
