using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EReporteWeb
    {
        public string Idmodulo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Titulo { get; set; } = null!;
        public string NombreArchivoCr { get; set; } = null!;
        public bool VistaPrevia { get; set; }
        public bool ImpresionComprobante { get; set; }
        public bool Acoplado { get; set; }
        public bool UbicacionLocal { get; set; }
        public bool TamañoPapelPersonalizado { get; set; }
        public string Idordenamiento { get; set; } = null!;
        public bool Activo { get; set; }
        public decimal TamañoPapelPersonalizadoAncho { get; set; }
        public decimal TamañoPapelPersonalizadoAlto { get; set; }
        public bool UsarBaseDatosReplica { get; set; }
        public int? ReporteWebAncho { get; set; }
        public int? ReporteWebLargo { get; set; }
        public bool? ReporteWebTamañoFijo { get; set; }
        public string? ReporteWebModoMostrar { get; set; }
        public bool? ReporteWebEnviarUsuario { get; set; }
        public bool? ReporteWebMostrarUrl { get; set; }
        public string ReporteWebId { get; set; } = null!;
        public string Id { get; set; } = null!;
        public string? ReporteWebUrl { get; set; }
    }
}
