using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class PropiedadCasoContable
    {
        public PropiedadCasoContable()
        {
            Condicions = new HashSet<Condicion>();
            PropiedadCasoContableReferencia = new HashSet<PropiedadCasoContableReferencium>();
        }

        public int Pkid { get; set; }
        public int IdcasoContable { get; set; }
        public int IdcuentaContableReferencia { get; set; }
        public string RutaPropiedadAtributo { get; set; } = null!;
        public string CargoAbono { get; set; } = null!;
        public string RutaReferenciaCtaCble { get; set; } = null!;
        public string RutaAuxiliar { get; set; } = null!;
        public string RutaDocPago { get; set; } = null!;

        public virtual CasoContable IdcasoContableNavigation { get; set; } = null!;
        public virtual CuentaContable IdcuentaContableReferenciaNavigation { get; set; } = null!;
        public virtual ICollection<Condicion> Condicions { get; set; }
        public virtual ICollection<PropiedadCasoContableReferencium> PropiedadCasoContableReferencia { get; set; }
    }
}
