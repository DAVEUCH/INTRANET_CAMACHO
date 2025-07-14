using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpOrdenPago
    {
        public CpOrdenPago()
        {
            ItemCpOrdenPagos = new HashSet<ItemCpOrdenPago>();
        }

        public int Pkid { get; set; }
        public string? NumCp { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaPago { get; set; }
        public bool Estado { get; set; }
        public int? Idmoneda { get; set; }
        public int? IdtipoCpOrdenPago { get; set; }
        public int? IdcptoOperacion { get; set; }
        public int? Idpersona { get; set; }
        public int? Idempleado { get; set; }
        public string? Observacion { get; set; }
        public decimal? Monto { get; set; }
        public int? IdmotivoOrdenPago { get; set; }
        public bool? EstadoFacturacion { get; set; }
        public int? IdcpCajaSalida { get; set; }

        public virtual CptoOperacion? IdcptoOperacionNavigation { get; set; }
        public virtual Empleado? IdempleadoNavigation { get; set; }
        public virtual Monedum? IdmonedaNavigation { get; set; }
        public virtual MotivoOrdenPago? IdmotivoOrdenPagoNavigation { get; set; }
        public virtual Persona? IdpersonaNavigation { get; set; }
        public virtual TipoCpOrdenPago? IdtipoCpOrdenPagoNavigation { get; set; }
        public virtual ICollection<ItemCpOrdenPago> ItemCpOrdenPagos { get; set; }
    }
}
