using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TomaInventario
    {
        public TomaInventario()
        {
            ListaTomaInventarios = new HashSet<ListaTomaInventario>();
            ProductoTomaInventarios = new HashSet<ProductoTomaInventario>();
        }

        public int Pkid { get; set; }
        public DateTime Fecha { get; set; }
        public string NumCp { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Idalmacen { get; set; }
        public int Idresponsable { get; set; }
        public int IdtipoCp { get; set; }
        public int Idsucursal { get; set; }
        public int Idmoneda { get; set; }
        public bool CerrarToma { get; set; }
        public string? TipoUnidad { get; set; }

        public virtual ICollection<ListaTomaInventario> ListaTomaInventarios { get; set; }
        public virtual ICollection<ProductoTomaInventario> ProductoTomaInventarios { get; set; }
    }
}
