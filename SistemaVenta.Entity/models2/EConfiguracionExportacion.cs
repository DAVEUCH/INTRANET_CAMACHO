using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionExportacion
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public string? Idreporte { get; set; }
        public string? ProcedimientoAlmacenado { get; set; }
        public bool? ActualizarEntidad { get; set; }
        public string? IdtipoReferenciado { get; set; }
        public string? RutaExportacion { get; set; }
        public string? Separador { get; set; }
        public string? NombreArchivo { get; set; }
        public bool? ConcatenarFechaEnNombre { get; set; }
        public string? FormatoFecha { get; set; }
        public bool? NombreTieneFormato { get; set; }
    }
}
