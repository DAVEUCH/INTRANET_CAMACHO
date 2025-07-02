using SistemaVenta.Entity.Models;

namespace SistemaVenta.AplicacionWeb.Models.ViewModels
{
    public class VMFormInterIngrePrint
    {
        public int IdFormInterIngre { get; set; }
        public string? NombPersona { get; set; }
        public string? ApePersona { get; set; }
        public string? FechaIng { get; set; }             // Formateado como "dd/MM/yyyy"
        public string? DniPersona { get; set; }
        public string? AreaPersona { get; set; }
        public string? CargPersona { get; set; }
        public string? TipoPuesto { get; set; }           // "Reemplazo" / "Puesto nuevo"

        // HARDWARE
        public string? HardwLapt { get; set; }            // "Sí" / "No"
        public string? HardwCompu { get; set; }
        public string? HardwCel { get; set; }

        // SOFTWARE
        public string? SoftOffice { get; set; }
        public string? SoftAntiv { get; set; }
        public string? SoftAdob { get; set; }
        public string? SoftCorr { get; set; }
        public string? SoftSys { get; set; }
        public string? SoftFlex { get; set; }

        public string? Observacion { get; set; }

        public string? Usuario { get; set; }
        public string? Estado { get; set; }               // "Activo" / "No Activo"
    }

}
