using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CategoriaCliente
    {
        public CategoriaCliente()
        {
            CanalBonificacions = new HashSet<CanalBonificacion>();
            CanalDescuentos = new HashSet<CanalDescuento>();
            Clientes = new HashSet<Cliente>();
            ListaPrecios = new HashSet<ListaPrecio>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool PorDefecto { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<CanalBonificacion> CanalBonificacions { get; set; }
        public virtual ICollection<CanalDescuento> CanalDescuentos { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<ListaPrecio> ListaPrecios { get; set; }
    }
}
