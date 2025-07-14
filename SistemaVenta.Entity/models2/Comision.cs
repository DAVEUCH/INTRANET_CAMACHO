using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Comision
    {
        public Comision()
        {
            CabComisionCuota = new HashSet<CabComisionCuotum>();
            CargosJeves = new HashSet<CargosJefe>();
            EscalaComisions = new HashSet<EscalaComision>();
            NivelVendedors = new HashSet<NivelVendedor>();
        }

        /// <summary>
        /// Es un campo autogenerado
        /// </summary>
        public int Pkid { get; set; }
        public string Mes { get; set; } = null!;
        public decimal Año { get; set; }
        public string? Descripcion { get; set; }
        public int Idsucursal { get; set; }
        public int IdcuotaVenta { get; set; }

        public virtual CuotaVentum IdcuotaVentaNavigation { get; set; } = null!;
        public virtual Sucursal IdsucursalNavigation { get; set; } = null!;
        public virtual ICollection<CabComisionCuotum> CabComisionCuota { get; set; }
        public virtual ICollection<CargosJefe> CargosJeves { get; set; }
        public virtual ICollection<EscalaComision> EscalaComisions { get; set; }
        public virtual ICollection<NivelVendedor> NivelVendedors { get; set; }
    }
}
