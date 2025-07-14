using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EPropiedadCasoContable
    {
        public int PropiedadesCasoContableId { get; set; }
        public int IdcasoContable { get; set; }
        public int PropiedadesCasoContableCuentaContableReferencia { get; set; }
        public string PropiedadesCasoContableRutaPropiedadAtributo { get; set; } = null!;
        public string PropiedadesCasoContableCargoAbono { get; set; } = null!;
        public string PropiedadesCasoContableRutaReferenciaCtaCble { get; set; } = null!;
        public string PropiedadesCasoContableRutaAuxiliar { get; set; } = null!;
        public string PropiedadesCasoContableRutaDocPago { get; set; } = null!;
    }
}
