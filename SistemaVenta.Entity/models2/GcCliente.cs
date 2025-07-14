using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GcCliente
    {
        public int? Idpersona { get; set; }
        public int? IdVendedor { get; set; }
        public int? IdStatClie { get; set; }
        public int? IdCondiClie { get; set; }
        public int? IdPadronClie { get; set; }
        public int? IdCategoriaVta { get; set; }
        public string? CondicionContribuyenteSunat { get; set; }
        public string? EstadoContribuyenteSunat { get; set; }
        public DateTime? FecUltVta { get; set; }
        public int? Score { get; set; }
        public string? ObservacionSunat { get; set; }
        public DateTime? FecAntAUltVta { get; set; }
        public int? CantVtasMesUlt12meses { get; set; }
        public int? IdVendedorUlt { get; set; }
        public DateTime? FecUltVtaContado { get; set; }
        public DateTime? FecUltVtaCredito { get; set; }
        public int? Refinancia { get; set; }
    }
}
