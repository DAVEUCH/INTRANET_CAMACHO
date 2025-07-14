using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ListaPreciosProveedor
    {
        public ListaPreciosProveedor()
        {
            ItemListaPreciosProveedors = new HashSet<ItemListaPreciosProveedor>();
        }

        public int Pkid { get; set; }
        public int Idproveedor { get; set; }
        public int Idmoneda { get; set; }
        public int Idimpuesto { get; set; }
        public bool? RestringirProveedor { get; set; }

        public virtual Impuesto IdimpuestoNavigation { get; set; } = null!;
        public virtual Monedum IdmonedaNavigation { get; set; } = null!;
        public virtual Persona IdproveedorNavigation { get; set; } = null!;
        public virtual ICollection<ItemListaPreciosProveedor> ItemListaPreciosProveedors { get; set; }
    }
}
