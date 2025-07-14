using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionImportacion
    {
        public ConfiguracionImportacion()
        {
            ItemConfiguracionImportacions = new HashSet<ItemConfiguracionImportacion>();
        }

        public int Pkid { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public string? IdtipoReferenciado { get; set; }
        public string? Separador { get; set; }
        public string? ActividadModificar { get; set; }
        public bool? CrearEnLote { get; set; }
        public bool? GuardarAutomatico { get; set; }

        public virtual Tipo? IdtipoReferenciadoNavigation { get; set; }
        public virtual ICollection<ItemConfiguracionImportacion> ItemConfiguracionImportacions { get; set; }
    }
}
