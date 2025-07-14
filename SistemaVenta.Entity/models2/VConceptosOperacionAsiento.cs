using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VConceptosOperacionAsiento
    {
        public string Cuenta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string CargoAbono { get; set; } = null!;
        public string RutaMonto { get; set; } = null!;
        public string RutaMoneda { get; set; } = null!;
        public string RutaCuentaContable { get; set; } = null!;
        public string RutaAuxiliar { get; set; } = null!;
        public string RutaDocCobrarPagar { get; set; } = null!;
        public string RutaColeccionComun { get; set; } = null!;
        public string RutaCentroDeCosto { get; set; } = null!;
        public int Posicion { get; set; }
        public int Orden { get; set; }
        public int IdasientoTipo { get; set; }
        public int IdcptoOperacion { get; set; }
    }
}
