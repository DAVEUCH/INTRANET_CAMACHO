using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemListaPrecioM
    {
        public int PkiditemListaPrecio { get; set; }
        public int PkidlistaPrecio { get; set; }
        public int PkidprodServ { get; set; }
        public bool Bonificacion { get; set; }
        public bool Desactivado { get; set; }
    }
}
