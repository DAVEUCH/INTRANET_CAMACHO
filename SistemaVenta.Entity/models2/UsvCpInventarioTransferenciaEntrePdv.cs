using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCpInventarioTransferenciaEntrePdv
    {
        public int IdtipoCp { get; set; }
        public string NumCpGuiaTransferencia { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }
        public string EstadoRecepcionGuiTrans { get; set; } = null!;
        public string? NumCpReqExis { get; set; }
        public string? EstadoSalidaReEx { get; set; }
        public string? EstadoEntradaReEx { get; set; }
        public string? Sucursal { get; set; }
        public bool Anulado { get; set; }
    }
}
