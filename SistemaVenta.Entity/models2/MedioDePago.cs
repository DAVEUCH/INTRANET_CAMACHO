using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MedioDePago
    {
        public MedioDePago()
        {
            CpCajas = new HashSet<CpCaja>();
            ItemConciliacionBancaria = new HashSet<ItemConciliacionBancarium>();
        }

        public int Pkid { get; set; }
        public int Idmoneda { get; set; }
        public int IdcajaUbicacion { get; set; }
        public int IdtipoMedioDePago { get; set; }
        public int Idpersona { get; set; }
        public int IdtipoPersona { get; set; }
        public int Idbanco { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Estado { get; set; } = null!;
        public string NumeroDocumento { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public decimal Total { get; set; }
        public bool Tercero { get; set; }
        public bool Anulado { get; set; }
        public int IdcpCaja { get; set; }
        public int IdtarjetaCredito { get; set; }
        public string PersonaNombre { get; set; } = null!;

        public virtual Banco IdbancoNavigation { get; set; } = null!;
        public virtual CpCaja IdcpCajaNavigation { get; set; } = null!;
        public virtual Persona IdpersonaNavigation { get; set; } = null!;
        public virtual TipoMedioDePago IdtipoMedioDePagoNavigation { get; set; } = null!;
        public virtual ICollection<CpCaja> CpCajas { get; set; }
        public virtual ICollection<ItemConciliacionBancarium> ItemConciliacionBancaria { get; set; }
    }
}
