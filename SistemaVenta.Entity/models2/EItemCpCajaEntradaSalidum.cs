using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemCpCajaEntradaSalidum
    {
        public int ItemCpCajaTransferenciaItemsId { get; set; }
        public int ItemCpCajaTransferenciaIditemCp { get; set; }
        public int ItemCpCajaTransferenciaItemsIdcpCajaSalida { get; set; }
        public int ItemCpCajaTransferenciaItemsIdcpCajaEntrada { get; set; }
        public decimal ItemCpCajaTransferenciaItemsDiferenciaTipoCambio { get; set; }
        public decimal ItemCpCajaTransferenciaItemsPerdidaPorDiferenciaTipoCambio { get; set; }
        public decimal ItemCpCajaTransferenciaItemsGananciaPorDiferenciaTipoCambio { get; set; }
        public decimal ItemCpCajaTransferenciaItemsTipoCambio { get; set; }
        public bool ItemCpCajaTransferenciaItemsTransferenciaMedioDePago { get; set; }
    }
}
