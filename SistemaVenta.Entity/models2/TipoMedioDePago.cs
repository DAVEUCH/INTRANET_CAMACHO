using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoMedioDePago
    {
        public TipoMedioDePago()
        {
            CajaTipoMedioDePagos = new HashSet<CajaTipoMedioDePago>();
            ItemConciliacionBancaria = new HashSet<ItemConciliacionBancarium>();
            MedioDePagos = new HashSet<MedioDePago>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool RequiereNumeroDocumento { get; set; }
        public bool RequiereFechaEmision { get; set; }
        public bool RequiereFechaPago { get; set; }
        public bool RequiereBanco { get; set; }
        public bool RequiereOperadorTarjetaCredito { get; set; }
        public bool Efectivo { get; set; }
        public bool PermitirMontoCero { get; set; }
        public bool SaldoDisponible { get; set; }
        public bool SaldoContable { get; set; }
        public bool Transferible { get; set; }

        public virtual ICollection<CajaTipoMedioDePago> CajaTipoMedioDePagos { get; set; }
        public virtual ICollection<ItemConciliacionBancarium> ItemConciliacionBancaria { get; set; }
        public virtual ICollection<MedioDePago> MedioDePagos { get; set; }
    }
}
