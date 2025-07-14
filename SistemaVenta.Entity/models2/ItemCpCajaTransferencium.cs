using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpCajaTransferencium
    {
        public int Pkid { get; set; }
        public int IdcajaEntrada { get; set; }
        public int IdcajaSalida { get; set; }
        public decimal DiferenciaTipoCambio { get; set; }
        public decimal PerdidaPorDiferenciaTipoCambio { get; set; }
        public decimal GananciaPorDiferenciaTipoCambio { get; set; }
        public decimal TipoCambio { get; set; }
        public bool AplicaConfiguracion { get; set; }
        public int IditemConfiguracionTransferencia { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
