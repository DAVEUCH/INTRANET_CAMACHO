using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemConfiguracionEntradaSalidum
    {
        public int ItemsId { get; set; }
        public int IditemConfiguracionTransferencia { get; set; }
        public int ItemsIdtipoMedioDePagoSalida { get; set; }
        public int ItemsIdtipoMedioDePagoEntrada { get; set; }
        public int ItemsIdmonedaSalida { get; set; }
        public int ItemsIdmonedaEntrada { get; set; }
        public decimal ItemsMonto { get; set; }
        public bool ItemsPorcentaje { get; set; }
        public bool ItemsTransferenciaMedioDePago { get; set; }
        public string ItemsFiltroMedioDePago { get; set; } = null!;
    }
}
