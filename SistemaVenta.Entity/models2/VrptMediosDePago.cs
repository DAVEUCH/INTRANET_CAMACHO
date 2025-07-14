using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptMediosDePago
    {
        public int MedioDePagoId { get; set; }
        public int MonedaId { get; set; }
        public string MonedaSimbolo { get; set; } = null!;
        public int? IdoperadorTarjetaCredito { get; set; }
        public int IdcajaUbicacion { get; set; }
        public DateTime MedioDePagoFechaPago { get; set; }
        public DateTime MedioDePagoFechaEmision { get; set; }
        public string MedioDePagoEstado { get; set; } = null!;
        public string MedioDePagoNumero { get; set; } = null!;
        public decimal MedioDePagoTotal { get; set; }
        public int TipoMedioDePagoId { get; set; }
        public string TipoMedioDePagoNombre { get; set; } = null!;
        public string? BancoOperador { get; set; }
        public int PersonaId { get; set; }
        public string PersonaNombre { get; set; } = null!;
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public int CajaId { get; set; }
        public string CajaNombre { get; set; } = null!;
        public int CajaTipoId { get; set; }
    }
}
