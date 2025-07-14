using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ELiquidacionTransportistum
    {
        public int Id { get; set; }
        public string Numero { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal TotalSoles { get; set; }
        public decimal TotalDolares { get; set; }
        public int IdtipoMedioDePago { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int Idresponsable { get; set; }
        public int IdtipoCpCobranza { get; set; }
        public int IdcptoCajaCobranza { get; set; }
        public int IdcajaCobranza { get; set; }
        public int IdcuentaContableCobranza { get; set; }
        public int Idcobranza { get; set; }
        public int Idgasto { get; set; }
        public int IdtipoCpPrestamo { get; set; }
        public int IdcptoCajaPrestamo { get; set; }
        public int IdcajaPrestamo { get; set; }
        public int IdtipoCpGasto { get; set; }
        public int IdcptoCajaGasto { get; set; }
        public int IdcajaGasto { get; set; }
        public int IdcuentaContableGasto { get; set; }
    }
}
