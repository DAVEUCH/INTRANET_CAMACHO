using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Entity.Models
{
    public partial class FormInterIngre
    {
        public int IdFormInterIngre { get; set; }
        public string? NombPersona { get; set; }
        public string? ApePersona { get; set; }
        public DateTime? FechaIng { get; set; }
        public string? DniPersona { get; set; }
        public string? AreaPersona { get; set; }
        public string? CargPersona { get; set; }
        public bool? TipoPuesto { get; set; }
        public bool? Hardwlapt { get; set; }
        public bool? Hardwcompu { get; set; }
        public bool? Hardwcel { get; set; }
        public bool? Softoffice { get; set; }
        public bool? SoftAntiv { get; set; }
        public bool? Softadob { get; set; }
        public bool? Softcorr { get; set; }
        public bool? Softsys { get; set; }
        public bool? Softflex { get; set; }
        public string? Observacion { get; set; }
        public int? IdUsuario { get; set; }
        public bool? Estado { get; set; }

        public virtual Usuario? IdUsuarioNavigation { get; set; }
    }
}

