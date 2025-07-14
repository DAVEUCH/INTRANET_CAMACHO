using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionExportacionOld
    {
        public ConfiguracionExportacionOld()
        {
            ItemConfiguracionExportacionColumnaOlds = new HashSet<ItemConfiguracionExportacionColumnaOld>();
            ItemConfiguracionNombreArchivoOlds = new HashSet<ItemConfiguracionNombreArchivoOld>();
        }

        public int Pkid { get; set; }
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

        public virtual ICollection<ItemConfiguracionExportacionColumnaOld> ItemConfiguracionExportacionColumnaOlds { get; set; }
        public virtual ICollection<ItemConfiguracionNombreArchivoOld> ItemConfiguracionNombreArchivoOlds { get; set; }
    }
}
