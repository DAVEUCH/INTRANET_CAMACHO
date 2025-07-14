using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ListaInventario
    {
        public ListaInventario()
        {
            ListaTomaInventarios = new HashSet<ListaTomaInventario>();
            ProductoListaInventarios = new HashSet<ProductoListaInventario>();
        }

        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public int IdresponsableConteo { get; set; }
        public int IdtipoCp { get; set; }
        public int Idalmacen { get; set; }
        public int Idsucursal { get; set; }
        public DateTime Fecha { get; set; }
        public int IdresponsableReconteo { get; set; }
        public int IdresponsableDigitador { get; set; }
        public string Observacion { get; set; } = null!;
        public string UnidadConteo { get; set; } = null!;

        public virtual Almacen IdalmacenNavigation { get; set; } = null!;
        public virtual Sucursal IdsucursalNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoCpNavigation { get; set; } = null!;
        public virtual ICollection<ListaTomaInventario> ListaTomaInventarios { get; set; }
        public virtual ICollection<ProductoListaInventario> ProductoListaInventarios { get; set; }
    }
}
