using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptEstructuraTerritorioVenta
    {
        public int IdgrupoVentas { get; set; }
        public string GrupoVentaCodigo { get; set; } = null!;
        public string GrupoVentaNombre { get; set; } = null!;
        public int Idsupervisor { get; set; }
        public string? SupervisorCodigo { get; set; }
        public string? SupervisorNombre { get; set; }
        public int IdfuerzaVentas { get; set; }
        public string FuerzaVentasCodigo { get; set; } = null!;
        public string FuerzaVentasNombre { get; set; } = null!;
        public int Idvendedor { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string? Lunes { get; set; }
        public string? Martes { get; set; }
        public string? Miercoles { get; set; }
        public string? Jueves { get; set; }
        public string? Viernes { get; set; }
        public string? Sabado { get; set; }
        public string? Domingo { get; set; }
    }
}
