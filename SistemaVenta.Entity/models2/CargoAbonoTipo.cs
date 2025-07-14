using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CargoAbonoTipo
    {
        public CargoAbonoTipo()
        {
            CargoAbonoTipoCondicions = new HashSet<CargoAbonoTipoCondicion>();
            CargoAbonoTipoReferencia = new HashSet<CargoAbonoTipoReferencium>();
        }

        public int Pkid { get; set; }
        public int IdasientoTipo { get; set; }
        public string OrigenCuentaContable { get; set; } = null!;
        public int IdcuentaContable { get; set; }
        public string RutaMonto { get; set; } = null!;
        public string RutaMoneda { get; set; } = null!;
        public string RutaCuentaContable { get; set; } = null!;
        public string RutaAuxiliar { get; set; } = null!;
        public string RutaDocCobrarPagar { get; set; } = null!;
        public string RutaColeccionComun { get; set; } = null!;
        public string CargoAbono { get; set; } = null!;
        public string Glosa { get; set; } = null!;
        public int Posicion { get; set; }
        public string RutaCentroDeCosto { get; set; } = null!;
        public string RutaCpCaja { get; set; } = null!;
        public string RutaTipoCambioComercial { get; set; } = null!;
        public string RutaMontoPercepcion { get; set; } = null!;

        public virtual AsientoTipo IdasientoTipoNavigation { get; set; } = null!;
        public virtual ICollection<CargoAbonoTipoCondicion> CargoAbonoTipoCondicions { get; set; }
        public virtual ICollection<CargoAbonoTipoReferencium> CargoAbonoTipoReferencia { get; set; }
    }
}
