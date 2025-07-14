using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemConfiguracionTransferencium
    {
        public int ItemsId { get; set; }
        public int IdconfiguracionTransferencia { get; set; }
        public int ItemsIdcajaEntrada { get; set; }
        public int ItemsIdcajaSalida { get; set; }
        public int Id { get; set; }
        public int IdcajaEntrada { get; set; }
        public int IdcajaSalida { get; set; }
    }
}
