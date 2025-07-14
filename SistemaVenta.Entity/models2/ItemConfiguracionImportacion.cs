using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConfiguracionImportacion
    {
        public int Pkid { get; set; }
        public string? Ruta { get; set; }
        public string? ValorPorDefecto { get; set; }
        public string? NombreColumna { get; set; }
        public bool? Indice { get; set; }
        public int? IdconfiguracionImportacion { get; set; }
        public string? AtributoDeBusqueda { get; set; }
        public int? PosicionColumna { get; set; }
        public bool? AsignacionReflexion { get; set; }
        public string? RutaValor { get; set; }
        public string? NombreTipoCargar { get; set; }

        public virtual ConfiguracionImportacion? IdconfiguracionImportacionNavigation { get; set; }
    }
}
