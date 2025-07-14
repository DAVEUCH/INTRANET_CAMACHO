using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionDireccionPersona2
    {
        public string PersonaDireccionDescripcion { get; set; } = null!;
        public string PersonaDistritoNombre { get; set; } = null!;
        public string PersonaProvinciaNombre { get; set; } = null!;
        public string PersonaDepartamentoNombre { get; set; } = null!;
        public string PersonaZonaCodigo { get; set; } = null!;
        public string PersonaZonaDescripcion { get; set; } = null!;
        public bool PersonaDireccionPrincipal { get; set; }
        public int PersonaDistritoId { get; set; }
        public int PersonaProvinciaId { get; set; }
        public int PersonaDepartamentoId { get; set; }
        public int PersonaZonaId { get; set; }
        public int PersonaId { get; set; }
        public int PersonaDireccionId { get; set; }
    }
}
