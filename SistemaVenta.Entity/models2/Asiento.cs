using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Asiento
    {
        public Asiento()
        {
            CargoAbonos = new HashSet<CargoAbono>();
        }

        public int Pkid { get; set; }
        public int Idvoucher { get; set; }
        public int IdlibroAuxiliar { get; set; }
        public string Glosa { get; set; } = null!;
        public decimal TotalCargo { get; set; }
        public decimal TotalAbono { get; set; }
        public decimal TotalCargoMonedaBase { get; set; }
        public decimal TotalAbonoMonedaBase { get; set; }
        public decimal Cuadre { get; set; }
        public bool EsTransferencia { get; set; }
        public bool ResumirEnLibroDiario { get; set; }

        public virtual LibroAuxiliar IdlibroAuxiliarNavigation { get; set; } = null!;
        public virtual VoucherContable IdvoucherNavigation { get; set; } = null!;
        public virtual ICollection<CargoAbono> CargoAbonos { get; set; }
    }
}
