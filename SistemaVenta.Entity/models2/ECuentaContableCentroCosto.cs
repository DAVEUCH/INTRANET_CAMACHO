using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECuentaContableCentroCosto
    {
        public int CentrosCostosId { get; set; }
        public int IdcuentaContable { get; set; }
        public int CentrosCostosIdcentroCosto { get; set; }
        public decimal CentrosCostosPorcentaje { get; set; }
        public int IdcentroCosto { get; set; }
        public int Id { get; set; }
        public decimal Porcentaje { get; set; }
    }
}
