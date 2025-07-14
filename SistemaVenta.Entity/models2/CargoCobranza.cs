using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CargoCobranza
    {
        public CargoCobranza()
        {
            ItemCargoCobranzas = new HashSet<ItemCargoCobranza>();
        }

        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int IdtipoCp { get; set; }
        public int Idempleado { get; set; }
        public int IdplanillaCobranza { get; set; }
        public decimal Total { get; set; }
        public bool Cerrado { get; set; }
        public int? IdcpCajaEntrada { get; set; }

        public virtual Empleado IdempleadoNavigation { get; set; } = null!;
        public virtual CpCajaEntradum IdplanillaCobranzaNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoCpNavigation { get; set; } = null!;
        public virtual ICollection<ItemCargoCobranza> ItemCargoCobranzas { get; set; }
    }
}
