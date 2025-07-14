using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionExportacion
    {
        public ConfiguracionExportacion()
        {
            ItemConfiguracionExportacionColumnas = new HashSet<ItemConfiguracionExportacionColumna>();
            ItemConfiguracionNombreArchivos = new HashSet<ItemConfiguracionNombreArchivo>();
        }

        public string Pkid { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Idreporte { get; set; }
        public string? ProcedimientoAlmacenado { get; set; }
        public bool? ActualizarEntidad { get; set; }
        public string? IdtipoReferenciado { get; set; }
        public string? Separador { get; set; }
        public string? NombreArchivo { get; set; }
        public bool? ConcatenarFechaEnNombre { get; set; }
        public string? FormatoFecha { get; set; }
        public string? RutaExportacion { get; set; }
        public bool? NombreTieneFormato { get; set; }

        public virtual ICollection<ItemConfiguracionExportacionColumna> ItemConfiguracionExportacionColumnas { get; set; }
        public virtual ICollection<ItemConfiguracionNombreArchivo> ItemConfiguracionNombreArchivos { get; set; }
    }
}
