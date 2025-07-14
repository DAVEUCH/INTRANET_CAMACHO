using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Entity.Models
{
    public partial class SubCategoriaSop
    {
        public SubCategoriaSop()
        {
            CategoriaSops = new HashSet<CategoriaSop>();
        }

        public int IdSubCategoriaSop { get; set; }
        public string? Descripcion { get; set; }
        public int? IdUsuario { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Usuario? IdUsuarioNavigation { get; set; }
        public virtual ICollection<CategoriaSop> CategoriaSops { get; set; }
    }
}
