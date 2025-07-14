using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Entity.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdEmpresa { get; set; }
        public string? Descripcion { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
