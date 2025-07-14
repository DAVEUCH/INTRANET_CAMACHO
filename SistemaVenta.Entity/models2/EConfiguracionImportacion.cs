using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionImportacion
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public string? IdtipoReferenciado { get; set; }
        public string? Separador { get; set; }
        public string? ActividadModificar { get; set; }
        public bool? CrearEnLote { get; set; }
        public bool? GuardarAutomatico { get; set; }
    }
}
