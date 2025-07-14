using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpCajaEntradaSalidum
    {
        public int Pkid { get; set; }
        public int IditemCp { get; set; }
        public int IdcpCajaSalida { get; set; }
        public int IdcpCajaEntrada { get; set; }
        public decimal DiferenciaTipoCambio { get; set; }
        public decimal PerdidaPorDiferenciaTipoCambio { get; set; }
        public decimal GananciaPorDiferenciaTipoCambio { get; set; }
        public decimal TipoCambio { get; set; }
        public bool TransferenciaMedioDePago { get; set; }

        public virtual CpCaja IdcpCajaEntradaNavigation { get; set; } = null!;
        public virtual CpCaja IdcpCajaSalidaNavigation { get; set; } = null!;
        public virtual ItemCp IditemCpNavigation { get; set; } = null!;
    }
}
