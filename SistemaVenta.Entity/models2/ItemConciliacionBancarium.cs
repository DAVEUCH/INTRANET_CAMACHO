using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConciliacionBancarium
    {
        public int Pkid { get; set; }
        public int IdconciliacionBancaria { get; set; }
        public int Idmoneda { get; set; }
        public int IdtipoMedioDePago { get; set; }
        public int IdmedioDePago { get; set; }
        public int Idbanco { get; set; }
        public int IdtarjetaCredito { get; set; }
        public int IdcuentaContable { get; set; }
        public DateTime FechaEmpresa { get; set; }
        public DateTime FechaBanco { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal ImporteEmpresa { get; set; }
        public decimal ImporteBanco { get; set; }
        public bool EnBanco { get; set; }
        public bool EnEmpresa { get; set; }
        public bool Conciliado { get; set; }
        public int CargoAbono { get; set; }
        public string Numero { get; set; } = null!;
        public string? IdtipoCpGenerado { get; set; }
        public int IdcentroDeCosto { get; set; }
        public string Observacion { get; set; } = null!;
        public int? IdcpGenerado { get; set; }

        public virtual ConciliacionBancarium IdconciliacionBancariaNavigation { get; set; } = null!;
        public virtual MedioDePago IdmedioDePagoNavigation { get; set; } = null!;
        public virtual Monedum IdmonedaNavigation { get; set; } = null!;
        public virtual TipoMedioDePago IdtipoMedioDePagoNavigation { get; set; } = null!;
    }
}
