using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpOrdenPago
    {
        public int Id { get; set; }
        public string? NumCp { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaPago { get; set; }
        public bool Estado { get; set; }
        public int? Idmoneda { get; set; }
        public int? IdtipoCpOrdenPago { get; set; }
        public string Simbolo { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public int? IdcptoOperacion { get; set; }
        public int? Idpersona { get; set; }
        public int? Idempleado { get; set; }
        public string? Observacion { get; set; }
        public decimal? Monto { get; set; }
        public int? IdmotivoOrdenPago { get; set; }
        public bool? EstadoFacturacion { get; set; }
        public int? IdcpCajaSalida { get; set; }
    }
}
