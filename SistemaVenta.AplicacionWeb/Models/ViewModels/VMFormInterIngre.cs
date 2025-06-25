using SistemaVenta.Entity.Models;

namespace SistemaVenta.AplicacionWeb.Models.ViewModels
{
    public class VMFormInterIngre
    {
        public int IdFormInterIngre { get; set; }
        public string? NombPersona { get; set; }
        public string? ApePersona { get; set; }
        public DateTime? FechaIng { get; set; }
        public string? DniPersona { get; set; }
        public string? AreaPersona { get; set; }
        public string? CargPersona { get; set; }
        public int? TipoPuesto { get; set; }
        public int? Hardwlapt { get; set; }
        public int? Hardwcompu { get; set; }
        public int? Hardwcel { get; set; }
        public int? Softoffice { get; set; }
        public int? SoftAntiv { get; set; }
        public int? Softadob { get; set; }
        public int? Softcorr { get; set; }
        public int? Softsys { get; set; }
        public int? Softflex { get; set; }
        public string? Observacion { get; set; }
        public int? IdUsuario { get; set; }
        public string? Usuario { get; set; }
        public int? Estado { get; set; }

        //public virtual Usuario? IdUsuarioNavigation { get; set; }

    }
}
