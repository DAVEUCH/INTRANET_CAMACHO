using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Periodo
    {
        public Periodo()
        {
            Cps = new HashSet<Cp>();
            NumCpContablePeriodos = new HashSet<NumCpContablePeriodo>();
            PeriodoCierres = new HashSet<PeriodoCierre>();
            SaldoPeriodoCuentaContables = new HashSet<SaldoPeriodoCuentaContable>();
            SaldoPeriodoSegmentoCuentaContables = new HashSet<SaldoPeriodoSegmentoCuentaContable>();
            VoucherContables = new HashSet<VoucherContable>();
        }

        public int Pkid { get; set; }
        public int Idejercicio { get; set; }
        public string Mes { get; set; } = null!;
        public bool Activo { get; set; }
        public bool Cerrado { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Apertura { get; set; }
        public bool Cierre { get; set; }
        public int Idconfiguracion { get; set; }
        public bool CierreNivel { get; set; }

        public virtual Ejercicio IdejercicioNavigation { get; set; } = null!;
        public virtual EnvioLibroElectronico EnvioLibroElectronico { get; set; } = null!;
        public virtual ICollection<Cp> Cps { get; set; }
        public virtual ICollection<NumCpContablePeriodo> NumCpContablePeriodos { get; set; }
        public virtual ICollection<PeriodoCierre> PeriodoCierres { get; set; }
        public virtual ICollection<SaldoPeriodoCuentaContable> SaldoPeriodoCuentaContables { get; set; }
        public virtual ICollection<SaldoPeriodoSegmentoCuentaContable> SaldoPeriodoSegmentoCuentaContables { get; set; }
        public virtual ICollection<VoucherContable> VoucherContables { get; set; }
    }
}
