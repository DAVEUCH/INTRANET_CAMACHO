using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Caja
    {
        public Caja()
        {
            CajaTipoMedioDePagos = new HashSet<CajaTipoMedioDePago>();
            ConciliacionBancaria = new HashSet<ConciliacionBancarium>();
            ConfiguracionConciliacionBancaria = new HashSet<ConfiguracionConciliacionBancarium>();
            CpCajaEntrada = new HashSet<CpCajaEntradum>();
            CpCajaSalida = new HashSet<CpCajaSalidum>();
            CpCajas = new HashSet<CpCaja>();
            LiquidacionCajas = new HashSet<LiquidacionCaja>();
            MovimientoCuentaBancos = new HashSet<MovimientoCuentaBanco>();
        }

        public int Pkid { get; set; }
        public int Idmoneda { get; set; }
        public int Idbanco { get; set; }
        public int Idsucursal { get; set; }
        public decimal SaldoSoles { get; set; }
        public decimal SaldoDolares { get; set; }
        public decimal SaldoDisponibleSoles { get; set; }
        public decimal SaldoDisponibleDolares { get; set; }
        public bool Sobregirable { get; set; }
        public decimal SobregiroSoles { get; set; }
        public decimal SobregiroDolares { get; set; }
        public bool EsBanco { get; set; }
        public string NumeroCheque { get; set; } = null!;
        public string NumeroCuenta { get; set; } = null!;
        public int NumeroDigitos { get; set; }
        public bool RestringirMoneda { get; set; }
        public bool GestionaTurnos { get; set; }
        public int IdtipoCaja { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Activo { get; set; }
        public int IdcuentaContable { get; set; }

        public virtual Banco IdbancoNavigation { get; set; } = null!;
        public virtual Sucursal IdsucursalNavigation { get; set; } = null!;
        public virtual ICollection<CajaTipoMedioDePago> CajaTipoMedioDePagos { get; set; }
        public virtual ICollection<ConciliacionBancarium> ConciliacionBancaria { get; set; }
        public virtual ICollection<ConfiguracionConciliacionBancarium> ConfiguracionConciliacionBancaria { get; set; }
        public virtual ICollection<CpCajaEntradum> CpCajaEntrada { get; set; }
        public virtual ICollection<CpCajaSalidum> CpCajaSalida { get; set; }
        public virtual ICollection<CpCaja> CpCajas { get; set; }
        public virtual ICollection<LiquidacionCaja> LiquidacionCajas { get; set; }
        public virtual ICollection<MovimientoCuentaBanco> MovimientoCuentaBancos { get; set; }
    }
}
