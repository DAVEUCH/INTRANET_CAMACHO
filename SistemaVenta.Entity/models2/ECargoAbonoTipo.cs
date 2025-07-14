using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECargoAbonoTipo
    {
        public int CargoAbonosTipoId { get; set; }
        public int IdasientoTipo { get; set; }
        public string CargoAbonosTipoOrigenCuentaContable { get; set; } = null!;
        public int CargoAbonosTipoIdcuentaContable { get; set; }
        public string CargoAbonosTipoRutaMonto { get; set; } = null!;
        public string CargoAbonosTipoRutaCuentaContable { get; set; } = null!;
        public string CargoAbonosTipoRutaAuxiliar { get; set; } = null!;
        public string CargoAbonosTipoRutaDocCobrarPagar { get; set; } = null!;
        public string CargoAbonosTipoCargoAbono { get; set; } = null!;
        public string CargoAbonosTipoRutaMoneda { get; set; } = null!;
        public string CargoAbonosTipoRutaColeccionComun { get; set; } = null!;
        public string CargoAbonosTipoGlosa { get; set; } = null!;
        public int CargoAbonosTipoPosicion { get; set; }
        public string CargoAbonosTipoRutaCentroDeCosto { get; set; } = null!;
        public string CargoAbonosTipoRutaCpCaja { get; set; } = null!;
        public string CargoAbonosTipoRutaTipoCambioComercial { get; set; } = null!;
    }
}
