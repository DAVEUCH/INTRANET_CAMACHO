using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemConfiguracionImportacion
    {
        public int ItemsId { get; set; }
        public string? ItemsRuta { get; set; }
        public string? ItemsValorPorDefecto { get; set; }
        public string? ItemsNombreColumna { get; set; }
        public bool? ItemsIndice { get; set; }
        public int? IdconfiguracionImportacion { get; set; }
        public string? ItemsAtributoDeBusqueda { get; set; }
        public int? ItemsPosicionColumna { get; set; }
        public bool? ItemsAsignacionReflexion { get; set; }
        public string? ItemsRutaValor { get; set; }
        public string? ItemsNombreTipoCargar { get; set; }
    }
}
