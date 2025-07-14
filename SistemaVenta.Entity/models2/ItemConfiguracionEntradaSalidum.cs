using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConfiguracionEntradaSalidum
    {
        public int Pkid { get; set; }
        public int IditemConfiguracionTransferencia { get; set; }
        public int IdtipoMedioDePagoSalida { get; set; }
        public int IdtipoMedioDePagoEntrada { get; set; }
        public int IdmonedaSalida { get; set; }
        public int IdmonedaEntrada { get; set; }
        public decimal Monto { get; set; }
        public bool Porcentaje { get; set; }
        public bool TransferenciaMedioDePago { get; set; }
        public string FiltroMedioDePago { get; set; } = null!;

        public virtual ItemConfiguracionTransferencium IditemConfiguracionTransferenciaNavigation { get; set; } = null!;
    }
}
